

import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Location } from '@angular/common';
import { RequestContext, RoleConfiguration, functionalprofile } from '../../../../models/model';
import { CommonService } from '../../../../shared/common.service';
import { setfunctionalprofileconfigurationservice } from '../../../services/setfunctionalprofile.service';
import { RolesconfigurationService } from 'src/app/modules/services/rolesconfiguration.service';
import { ToastrService } from 'ngx-toastr';
import { NgxSpinnerService } from 'ngx-spinner';


@Component({
  selector: 'app-setfunctionalprofile',
  templateUrl: './setfunctionalprofile.component.html'
  
})
export class SetfunctionalprofileComponent implements OnInit {
  isButtonDisabled = false;
  types: functionalprofile[]=[];
  roleTypes: RoleConfiguration[] = [];
  selectedRoles=new  RoleConfiguration();
  profile=new functionalprofile()
  editMode:boolean=false;
  viewMode:boolean=false;
  access:boolean=false;
  constructor(private commonsvc: CommonService, private doctypeservice: RolesconfigurationService ,
    private setprofileservice: setfunctionalprofileconfigurationservice  ,
    private toaster:ToastrService,
    private location: Location,
    private loader:NgxSpinnerService,
    private router: Router) { }

  ngOnInit() {
    debugger
    console.log(this.commonsvc.getUsername());
    this.access = this.commonsvc.getUsername().toLocaleLowerCase() === 'admin' ? true : false;
    this.getsetfunctionalprofile();
    this.getroles();
  }
getsetfunctionalprofile() {
 this.loader.show();
      return this.setprofileservice.getsetfunctionalprofileconfiguration(this.commonsvc.req).subscribe((data: any) => {
        this.types = data.Response;
        this.loader.hide();
        console.log(this.types);
      }, er => {
     
      });
  }
  getroles() {
    this.loader.show();
       return this.doctypeservice.getroles(this.commonsvc.req).subscribe((data: any) => {
         this.roleTypes = data.Response; 
         this.loader.hide();        
       });
   }
  onSubmit(profileinfo:functionalprofile)
  {   
    debugger
    this.loader.show();
    if(profileinfo.sfpid>0){
      profileinfo.modifiedby=this.commonsvc.getUsername();
      if(profileinfo.createdby==null || undefined){
        profileinfo.createdby=this.commonsvc.getUsername();
      }
      if (!this.isButtonDisabled) {
        this.isButtonDisabled = true;
      this.setprofileservice.update(profileinfo).subscribe((data:any)=>{
        this.toaster.success('role permissions updated');
        this.loader.hide();
        this.isButtonDisabled=false;
      })
    }
    }
    else{
    profileinfo.createdby=this.commonsvc.getUsername();
    profileinfo.modifiedby=this.commonsvc.getUsername();
    //profileinfo.role=this.selectedRoles.Role;
    if (!this.isButtonDisabled) {
      this.isButtonDisabled = true;
    this.setprofileservice.addsetfunctionalprofileconfiguration(profileinfo).subscribe((res: any) => {
      this.toaster.success('role permissions added');
      this.loader.hide();
      this.isButtonDisabled=false;
  });
}
}
  }
  binddata(rolename:String){
    debugger
    const role=this.types.find(o=>o.role==rolename);
    if(role!=null && role!=undefined)
    {
      this.profile=role;
      console.log(this.profile);
    }
  }
  onCancel()
  {
    this.location.back();
  }
}
