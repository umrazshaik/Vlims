import { Component, OnInit, ViewChild } from '@angular/core';

import { Router } from '@angular/router';
import { Paginator } from 'primeng/paginator';
import { Table } from 'primeng/table';
import { RequestContext, RoleConfiguration, UserConfiguration } from '../../../../models/model';
import { CommonService } from '../../../../shared/common.service';
import { UsersconfigurationService } from '../../../services/usersconfiguration.service';



@Component({
  selector: 'app-user-configuration',
  templateUrl: './user-configuration.component.html'
  
})
export class UserConfigurationComponent implements OnInit {
  @ViewChild('dt') dataTable!: Table; // ViewChild to get reference to the p-table component
  @ViewChild('paginator') dataPaginator!: Paginator; // ViewChild to get reference to the p-paginator component
  // Pagination properties
  currentPage = 1;
  itemsPerPage = 10;
  rowsPerPageOptions = [10, 20, 50];

  name: string = 'Product Type';
  newtype: UserConfiguration | undefined;
  objProductType: UserConfiguration | undefined;
  retailId: number=0;
  header: string='';
  actiontype: number=0;
  pageConfig: any;
  searchstr: string='';

  constructor(private commonsvc: CommonService, private doctypeservice: UsersconfigurationService ,private router: Router) { }

  ngOnInit() {
    this.getusers();
  }
  getusers() {
   let objrequest: RequestContext={PageNumber:1,PageSize:50,Id:0};
      return this.doctypeservice.getusers(objrequest).subscribe((data: any) => {
        debugger
        this.types = data.Response;
        
        console.log(this.types);
      }, er => {
       
      });
  }
  editdoc(doc: UserConfiguration) {
    debugger
    this.commonsvc.userConfig = doc;
    this.router.navigate(['/admin/users/edit', doc.UCFId]);
  }

  navigateToAddUser(): void {
    this.router.navigate(['/admin/users/add']);
  }
  
  getStatusClass(status: string): string {
    debugger
    if (status === 'In Progress') {
      return 'status-in-progress';
    } else if (status === 'Completed') {
      return 'status-completed';
    } else if (status === 'Under Review') {
      return 'status-under-review';
    } else if (status === 'Pending') {
      return 'status-in-progress';
    } else {
      return '';
    }
  }
  addusergroup()
  {
    
  }

}
