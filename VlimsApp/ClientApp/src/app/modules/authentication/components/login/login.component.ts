import { Component, ElementRef, EventEmitter, Output,Renderer2 ,ViewChild  } from '@angular/core';
import { LoginService } from '../../services/login.service';
import { Router } from '@angular/router';
import { UsersconfigurationService } from 'src/app/modules/services/usersconfiguration.service';
import { RequestContext, UserConfiguration, functionalprofile } from 'src/app/models/model';
import { CommonService } from 'src/app/shared/common.service';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { SetfunctionalprofileComponent } from '../set-functional-profile/setfunctionalprofile.component';
import { setfunctionalprofileconfigurationservice } from 'src/app/modules/services/setfunctionalprofile.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss'],
})
//const AUTH_STORAGE_KEY = 'isLoggedIn';
export class LoginComponent {
  @ViewChild('usernameInput') usernameInput!: ElementRef;
  @Output() loginSuccess: EventEmitter<void> = new EventEmitter<void>();
  lstusers:UserConfiguration[]=[];
  user:UserConfiguration=new UserConfiguration();
  roles:functionalprofile[]=[];
  username: string = '';
  password: string = '';
  constructor(private router: Router,private loginService: LoginService,private userssvc:UsersconfigurationService,
    private toastr:ToastrService,
    private renderer: Renderer2,
    private setfunctionalsvc:setfunctionalprofileconfigurationservice,
    private usersvc:UsersconfigurationService,
   private loader:NgxSpinnerService,private commonsvc:CommonService ) {}

   ngOnInit(){
    //this.getusers();
    this.getsetfunctionalprofile();
    this.checkadminuser();
   }
  checkadminuser() {
    this.loader.show();
    //check admin user exists or not
    //if admin user not exist then create with default password
    const admin=new UserConfiguration();
    admin.UserID="Admin";
    this.userssvc.login(admin).subscribe((data:any)=>{
          
      this.user=data;
      console.log('admin',this.user);
      this.loginService.updateuser(this.roles,this.user);
      this.isvaliduser();
      this.loader.hide();
  },(error:any)=>{
    //create admin user
    this.createadminuser(this.user);
  });
  }
  createadminuser(user: UserConfiguration) {
    throw new Error('Method not implemented.');
  }
   ngAfterViewInit() {
    // Set focus on the input element when the view is initialized
    this.renderer.selectRootElement(this.usernameInput.nativeElement).focus();
  }
  login() {
    debugger
    this.loader.show();
    // if(this.user.UserID.toLocaleLowerCase()==='admin')
    // {
    // if(this.loginService.login(this.user.UserID, this.user.Password ?? '',this.lstusers,this.roles)){
    //   this.isvaliduser();
    // }
    // else{
    //   this.toastr.error('login failed');
    //     }
    //   }
    //   else{

        this.userssvc.login(this.user).subscribe((data:any)=>{
          debugger
            this.user=data;
            this.commonsvc.setUser(this.user);
            if(this.user.UserID==="Admin")
            {
              this.loginService.updateuser(this.roles,this.user);
              this.commonsvc.setadminroles();
            }
            else{
            this.loginService.updateuser(this.roles,this.user);
            }
            this.isvaliduser();
        },(error:any)=>{
          this.loader.hide();
          this.toastr.error('login failed');
        });
      //}

  }
  isvaliduser(){
    debugger
    localStorage.setItem("username", this.user.UserID);
    this.commonsvc.setUsername(this.user.UserID);
    this.commonsvc.createdBy=this.user.UserID;
    this.loader.hide();
    this.loginSuccess.emit();
    this.router.navigate(['/documents']);
    this.commonsvc.startSessionTimeout(30);
    this.toastr.success('Welcome '+this.user.UserID, 'Login Success', {
      timeOut: 1000, // Set the display time in milliseconds (3 seconds)
    });
  }
  getusers(){
    
    this.loader.show();
    let objrequest=new RequestContext();
    objrequest.PageNumber=1;objrequest.PageSize=50;
      return this.userssvc.getusers(objrequest).subscribe((data:any)=>{
        this.lstusers=data.Response;
        this.loader.hide();
      });
  }
  getsetfunctionalprofile() {
    this.loader.show();
       return this.setfunctionalsvc.getsetfunctionalprofileconfiguration(this.commonsvc.req).subscribe((data: any) => {
         this.roles = data.Response;
         this.loader.hide();
       });
      }
}
