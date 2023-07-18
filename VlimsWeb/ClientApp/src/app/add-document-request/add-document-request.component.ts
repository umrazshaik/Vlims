import { ChangeDetectorRef, Component, OnInit } from '@angular/core';
import * as $ from 'jquery';
import { DocumentRequestConfiguration, DocumentTypeConfiguration, RequestContext } from '../model/models';
import { Router } from '@angular/router';
import { CommonService } from '../shared/common.service';
import { DocumentRequestService } from '../Services/document-request.service';
import { ToastrService } from 'ngx-toastr';
import { SpinnerService } from '../spinner/spinner.service';

@Component({
  selector: 'app-add-document-request',
  templateUrl: './add-document-request.component.html',
  styleUrls: ['./add-document-request.component.css']
})
export class AddDocumentRequestComponent implements OnInit {
  adddocreq = new DocumentRequestConfiguration();
  requests: Array<DocumentRequestConfiguration> = [];
  editMode: boolean = false;
  viewMode: boolean = false;
  title: string = '';
  constructor(private commonsvc: CommonService, private docReqServ: DocumentRequestService, private router: Router, private toastr: ToastrService, private cdr: ChangeDetectorRef, private loader: SpinnerService,) { }
  ngOnInit() {
    const urlPath = this.router.url;
    const segments = urlPath.split('/');
    const lastSegment = segments[segments.length - 1];
    this.getdocumentrequest();
    debugger;
    if (lastSegment == "viewdocreq") {
      this.viewMode = this.commonsvc.docrequest != null ? true : false;
      if (this.viewMode) {
        this.adddocreq = this.commonsvc.docrequest;
        this.title = "View Document Request"
      }
      this.cdr.detectChanges();
    }
    if (lastSegment == "editdocreq") {

      this.editMode = this.commonsvc.docrequest != null ? true : false;
      if (this.editMode) {
        this.adddocreq = this.commonsvc.docrequest;
        this.title = "Edit Document Request"
        this.cdr.detectChanges();
        this.loader.hide();
      }
    }

    $('select').selectpicker();
  }
  getdocumentrequest() {
    let objrequest: RequestContext = { PageNumber: 1, PageSize: 50, Id: 0 };
    this.docReqServ.getdocumentrequest(objrequest).subscribe((data: any) => {
      debugger
      this.requests = data.response;
    });
  }
  submit(adddocreq: DocumentRequestConfiguration) {
    debugger

    this.adddocrequest(adddocreq);

  }
  adddocrequest(adddocreq: DocumentRequestConfiguration) {
    debugger
    adddocreq.CreatedBy = "admin";
    adddocreq.ModifiedBy = "admin";
    //this.router.navigate(['/products']);
    this.docReqServ.adddocreqconfig(adddocreq).subscribe((res: any) => {
      this.toastr.success('Added');
      this.router.navigate(['/mainpage/documentmanager']);
    });

  }
  closepopup() {
    this.router.navigate(['/mainpage/documentmanager']);
  }
}




