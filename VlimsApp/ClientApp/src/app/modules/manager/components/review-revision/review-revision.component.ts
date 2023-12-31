import { Component, TemplateRef } from '@angular/core';
import { Location } from '@angular/common';
import { ActivatedRoute, Router } from '@angular/router';
import { CommonService } from 'src/app/shared/common.service';
import { NgxSpinnerService } from 'ngx-spinner';
import { DocumentAdditionalTasks, RequestContext, WorkItemsConfiguration, workflowconiguration } from 'src/app/models/model';
import { ToastrService } from 'ngx-toastr';
import { DocumentRevisionService } from 'src/app/modules/services/document-revision.service';
import { DepartmentconfigurationService } from 'src/app/modules/services/departmentconfiguration.service';
import { DocumentTypeServiceService } from 'src/app/modules/services/document-type-service.service';
import { WorkitemsService } from 'src/app/modules/services/workitems.service';
import { WorkflowServiceService } from 'src/app/modules/services/workflow-service.service';
import { DocumentPreperationService } from 'src/app/modules/services/document-preperation.service';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { DomSanitizer, SafeResourceUrl } from '@angular/platform-browser';
import { DocumentTemplateServiceService } from 'src/app/modules/services/document-template-service.service';

@Component({
  selector: 'app-review-revision',
  templateUrl: './review-revision.component.html',
  styleUrls: ['./review-revision.component.scss']
})
export class ReviewRevisionComponent {
  isButtonDisabled = false;
  revision = new DocumentAdditionalTasks();
  editMode: boolean = false;
  viewMode: boolean = false;
  id: string = '';
  effectiveDate: string | undefined;
  reviewDate: string | undefined;
  departmentsSource = []; workflownamee: string = ''
  typeSource = []; workflowsSource: workflowconiguration[] = [];
  requestId: number = 0; workId: number = 0; statuss: string = ''; iscompleted: boolean = false; type: string = ''
  username: string = ''
  workitems: Array<WorkItemsConfiguration> = [];
  finalStatus: string = '';
  fileBytes: Uint8Array = new Uint8Array();
  modalRef: BsModalRef | undefined;
  pdfBytes: Uint8Array | undefined;
  safePdfDataUrl: SafeResourceUrl | undefined;
  data: string = '<base64-encoded-data>';
  pdfUrl: string | null = null;

  constructor(private router: Router, private location: Location, private toastr: ToastrService, private route: ActivatedRoute,
    private spinner: NgxSpinnerService, private commonsvc: CommonService,
    private workitemssvc: WorkitemsService,
    private wfservice: WorkflowServiceService,
    private docPreperationService: DocumentPreperationService,
    private documentRevisionService: DocumentRevisionService,
    private modalService: BsModalService, private sanitizer: DomSanitizer,
    private templateService:DocumentTemplateServiceService,
    private deptservice: DepartmentconfigurationService, private doctypeserv: DocumentTypeServiceService) { }

  ngOnInit() {
    const user = localStorage.getItem("username");
    if (user != null && user != undefined) {
      this.commonsvc.createdBy = user;
      this.username = user;
    }    
    this.id = this.route.snapshot.paramMap.get('id') ?? '';
    this.getdepartments();
    this.getdocumenttypeconfig();
    this.getworkflowinfo();
    if (this.id) { //edit mode
      this.editMode = true;
      if (this.commonsvc.revision.atid) {
        this.revision = this.commonsvc.revision;
        this.workflownamee=this.revision.workflow;
        this.effectiveDate = this.toDate(this.revision.effectiveDate);
        this.reviewDate = this.toDate(this.revision.reviewDate);
      }
      else
        this.getDocumentRevision(Number.parseInt(this.id));
    }
  }
  getbyId(arg0: number) {
    this.spinner.show();
    return this.documentRevisionService.getbyId(arg0).subscribe((data: any) => {
      this.revision = data;      
      this.spinner.hide();
    });
  }
  approve() {
    this.revision.modifiedBy = this.username;
    this.revision.status = this.finalStatus;
    alert(this.revision.status);
    this.saveRequest();
  }
  reinitiative() {
    this.location.back();
  }
  reject() {
    this.revision.modifiedBy = this.commonsvc.getUsername();
    this.revision.status = 'Rejected'   
    this.updateRequest();
  }
  toDate(pdate: Date | undefined) {
    if (pdate == undefined) return undefined;
    pdate = new Date(pdate);
    const yyyy = pdate.getFullYear();
    let mm = pdate.getMonth() + 1;
    let dd = pdate.getDate();
    return yyyy + '-' + (mm < 10 ? '0' : '') + mm + '-' + (dd < 10 ? '0' : '') + dd;
  }
  getAsDate(event: any) {
    return event.target.valueAsDate;
  }

  getDocumentRevision(id: number) {
    this.spinner.show();
    return this.documentRevisionService.getbyId(id).subscribe((data: any) => {
      this.revision = data;
      this.workflownamee=this.revision.workflow;
      this.effectiveDate = this.toDate(this.revision.effectiveDate);
      this.reviewDate = this.toDate(this.revision.reviewDate);
      this.spinner.hide();
    });
  }
  getdepartments() {
    let objrequest: RequestContext = { PageNumber: 1, PageSize: 1, Id: 0 };
    this.deptservice.getdepartments(objrequest).subscribe((data: any) => {
      this.departmentsSource = data.Response;
    });
  }
  getdocumenttypeconfig() {
    let objrequest: RequestContext = { PageNumber: 1, PageSize: 1, Id: 0 };
    this.doctypeserv.getdoctypeconfig(objrequest).subscribe((data: any) => {
      this.typeSource = data.Response;

    });
  }
  getworkflowinfo() {
    //let objrequest: RequestContext = { PageNumber: 1, PageSize: 1, Id: 0 };
    this.wfservice.getworkflow(this.commonsvc.req).subscribe((data: any) => {
      this.workflowsSource = data.Response;
      this.workflowsSource=this.workflowsSource.filter(o=>o.documentstage?.includes("Revison"));
    });
  }
  saveRequest() {
    debugger
    this.revision.status = "Revision";
    //if (this.revision.workflow.toLocaleLowerCase() != this.workflownamee.toLocaleLowerCase()) {
      if (this.editMode || this.viewMode) {
        this.updateRequest();
      }
      else {
        this.addRequest();
      }
    // }
    // else {
    //   this.toastr.error('same workflow cannot create revision');
    // }
  }

  addRequest() {
    if (!this.viewMode) {
      this.revision.createdBy = 'admin';
      this.revision.modifiedBy = 'admin';
      this.revision.status = 'In-Progress';
      this.revision.createdDate = new Date();
      this.revision.modifiedDate = new Date();
      this.spinner.show();
      if (!this.isButtonDisabled) {
        this.isButtonDisabled = true;
      this.documentRevisionService.adddocrevconfig(this.revision).subscribe(res => {
        this.spinner.hide();
        this.toastr.success('Document Request Saved Succesfull!', 'Saved.!');
        this.location.back();
        this.isButtonDisabled=false;
      }, er => {
        console.log(er);
        this.spinner.hide();
      });
    }
    }
  }

  updateRequest() {
    if (this.viewMode) {
      this.revision.modifiedBy = this.commonsvc.createdBy;
      //this.revision.status = this.finalStatus;
    }
    this.spinner.show();
    if (!this.isButtonDisabled) {
      this.isButtonDisabled = true;
    this.documentRevisionService.updatedocrevconfig(this.revision).subscribe(res => {
      this.commonsvc.revision = new DocumentAdditionalTasks();
      this.toastr.success('Document Revision Succesfull!', 'Saved.!');
      this.spinner.hide();
      this.location.back();
      this.isButtonDisabled=false;
    }, er => {
      console.log(er);
      this.spinner.hide();
    });
  }
  }

  onCancel() {
    this.location.back();
  }
  getworkflowitems() {
    this.spinner.show();
    const user = localStorage.getItem("username");
    if (user != null && user != undefined) {
      this.commonsvc.createdBy = user;
    }
    return this.workitemssvc.getworkitems(this.commonsvc.req).subscribe((data: any) => {
      debugger
      this.workitems = data.Response;
      if (this.workitems.length > 0) {
        this.workitems = this.workitems.filter(p => p.ReferenceId == this.requestId);
        if (this.workitems) {
          this.workitems.sort((a, b) => a.WITId - b.WITId);
          const work = this.workitems.filter(o => o.WITId == this.workId);
          this.statuss = work[0].ActionType;
          this.iscompleted = work[0].IsCompleted;
          const totalreviewcount = this.workitems.filter(o => o.ActionType === this.statuss).length;
          const reviewedcount = this.workitems.filter(o => o.ActionType === 'Review' && o.IsCompleted).length;
          const countt = totalreviewcount - reviewedcount;
          if (this.statuss === 'Review') {
            if (countt === 1) {
              this.finalStatus = 'Reviewed';
            } else if (countt > 1) {
              this.finalStatus = 'Pending Review';
            } else if (countt === totalreviewcount) {
              this.finalStatus = 'Pending Review';
            }
          } else {
            if (countt === 1) {
              this.finalStatus = 'Approved';
            } else if (countt > 1) {
              this.finalStatus = 'Pending Approve';
            } else if (countt === totalreviewcount) {
              this.finalStatus = 'Pending Approve';
            }
          }
        }
      }
      this.spinner.hide();
    });
  }

  previewtemplate(template: TemplateRef<any>) {
    this.spinner.show();
    this.templateService.getTemplate(this.revision.template).subscribe((data: any) => {
    //this.docPreperationService.preview(this.revision.template).subscribe((data: any) => {
      this.fileBytes = data;
      this.pdfBytes = this.fileBytes;
      this.spinner.hide();
      this.openViewer(template);
    }, er => {
      this.spinner.hide();
    });
  }
  openViewer(template: TemplateRef<any>): void {

    if (this.pdfBytes) {
      const pdfBlob = this.b64toBlob(this.pdfBytes.toString(), 'application/pdf');
      this.pdfUrl = this.sanitizer.bypassSecurityTrustResourceUrl(URL.createObjectURL(pdfBlob)) as string;
      this.modalRef = this.modalService.show(template, { class: 'modal-lg' });
    }
  }

  // Function to convert base64 to Blob
  private b64toBlob(b64Data: string, contentType: string = '', sliceSize: number = 512): Blob {
    const byteCharacters = atob(b64Data);
    const byteArrays = [];
    for (let offset = 0; offset < byteCharacters.length; offset += sliceSize) {
      const slice = byteCharacters.slice(offset, offset + sliceSize);
      const byteNumbers = new Array(slice.length);
      for (let i = 0; i < slice.length; i++) {
        byteNumbers[i] = slice.charCodeAt(i);
      }
      const byteArray = new Uint8Array(byteNumbers);
      byteArrays.push(byteArray);
    }
    return new Blob(byteArrays, { type: contentType });
  }
  closeModel() {
    if (this.modalRef)
      this.modalRef.hide();
  }
}
