import { Component, OnInit } from '@angular/core';
import { Location } from '@angular/common';

import { Router } from '@angular/router';
import { TemplateForm } from '../../models/templates';
import { DocumentTemplateConfiguration, DocumentTypeConfiguration, RequestContext } from 'src/app/models/model';
import { DocumentTypeServiceService } from 'src/app/modules/services/document-type-service.service';
import { NgxSpinnerService } from 'ngx-spinner';
import { CommonService } from 'src/app/shared/common.service';
import { DocumentTemplateServiceService } from 'src/app/modules/services/document-template-service.service';




interface SelectOption {
  name: string;
  value: number;
}

@Component({
  selector: 'app-add-template',
  templateUrl: './add-template.component.html',
  styleUrls: ['./add-template.component.scss'],
})
export class AddTemplateComponent implements OnInit {
  title:string='New Document Template';
  typesDatasource: DocumentTypeConfiguration[] = [];
  selectedtype=new DocumentTypeConfiguration();
  templateForm=new DocumentTemplateConfiguration();
  showGrid: boolean = false;
  rows: number = 0;
  cols: number = 0;
  rowsArray: number[] = [];
  colsArray: number[] = [];
  gridData: any = [];

  footerRows: number = 0;
  footerCols: number = 0;
  rowsFooterArray: number[] = [];
  colsFooterArray: number[] = [];
  gridFooterData: any = [];

  selectOptions: SelectOption[] = [
    { name: 'Label', value: 1 },
    { name: 'Field', value: 2 },
    { name: 'Property', value: 3 },
    { name: 'Custom', value: 4 },
  ];
  viewMode:boolean=false;editMode:boolean=false;
  // templateForm: TemplateForm = {
  //   id: 0,
  //   templateName: '',
  //   uniqueCode: 'System Generated',
  //   description: '',
  //   docType:'',
  //   selectedDepartments: [],
  //   status: '',
  // };

  constructor(
    private location: Location,
    private doctypeservice:DocumentTypeServiceService,
    private loader:NgxSpinnerService,
    private commonsvc:CommonService,
    private templatesvc:DocumentTemplateServiceService,
    private router: Router
  ) {}

  ngOnInit(): void {
    debugger
    const urlPath = this.router.url;
    const segments = urlPath.split('/');
    const lastSegment = segments[segments.length - 2];
    this.rows = 1;
    this.cols = 1;
    this.generateTeplateGrid();
    this.footerRows = 1;
    this.footerCols = 1;
    this.generateFooterGrid();
    //this.commonsvc.templateCount++; // Increment the templateCount
    if(lastSegment=="add")
    {
     let addcount=parseInt(segments[segments.length - 1],10);
     addcount++;
    this.templateForm.Uniquecode="Temp "+addcount;  
    this.getdocumenttypeconfig();
    }
    else if(lastSegment=="edit")
    {
      this.title='Edit Document Template';
        let id=parseInt(segments[segments.length-1],10);
        this.getdocumenttypeconfig();
        this.getbyId(id);
    }
    else if(lastSegment=="view")
    {
      this.title='View Document Template';
        let id=segments[segments.length-1];
        this.getdocumenttypeconfig();
        this.getbyName(id);
    }
    
  }
  getbyId(id:number)
  {
    debugger
    this.loader.show();
    this.templatesvc.getbyId(id).subscribe((data:any)=>{
      debugger
      this.templateForm=data;
      if(this.typesDatasource.length>0)
      {
      let obj=this.typesDatasource.filter(p=>p.Documenttypename==this.templateForm.documenttype);
      this.selectedtype=obj[0];
      }
      this.rows=parseInt(this.templateForm.rows,10);
      this.cols=parseInt(this.templateForm.columns,10);
      this.footerRows=parseInt(this.templateForm.footerrows,10);
      this.footerCols=parseInt(this.templateForm.footercolumns,10);
      this.gridData=this.templateForm.headerTable;
      this.gridFooterData=this.templateForm.footerTable;
      console.log(this.templateForm);
      this.loader.hide();
    },(error:any)=>{

    });
  }
  getbyName(name:string)
  {
    debugger
    this.loader.show();
    this.templatesvc.getdoctemplatebyname(name).subscribe((data:any)=>{
      debugger
      this.templateForm=data;
      if(this.typesDatasource.length>0)
      {
      let obj=this.typesDatasource.filter(p=>p.Documenttypename==this.templateForm.documenttype);
      this.selectedtype=obj[0];
      }
      this.rows=parseInt(this.templateForm.rows,10);
      this.cols=parseInt(this.templateForm.columns,10);
      this.footerRows=parseInt(this.templateForm.footerrows,10);
      this.footerCols=parseInt(this.templateForm.footercolumns,10);
      this.gridData=this.templateForm.headerTable;
      this.gridFooterData=this.templateForm.footerTable;
      console.log(this.templateForm);
      this.loader.hide();
    },(error:any)=>{

    });
  }
  addTemplate() {
    debugger
    this.templateForm.documenttype=this.selectedtype.Documenttypename;
    this.templateForm.headerTable=this.gridData;
    this.templateForm.footerTable=this.gridFooterData;
    this.templateForm.rows=this.rowsArray.length.toString();
    this.templateForm.columns=this.colsArray.length.toString();
    this.templateForm.footerrows=this.rowsFooterArray.length.toString();
    this.templateForm.footercolumns=this.colsFooterArray.length.toString();
    this.templatesvc.adddoctemplate(this.templateForm).subscribe((data:any)=>{
    }, (error:any) => {
      this.loader.hide();
    });
    //let type=this.templateForm.documenttype.Documenttypename
    //this.documentService.addTemplate(this.templateForm).subscribe(() => {
    this.router.navigate(['/templates']);
    //});
  }

  onCancel() {
    this.location.back();
  }

  generateTeplateGrid() {
    this.showGrid = true;
    // Set the number of rows and columns based on user input
    // this.rows = 5;
    // this.cols = 5;
    this.rowsArray = Array.from({ length: this.rows });
    this.colsArray = Array.from({ length: this.cols });

    this.gridData = [];
    for (let i = 0; i < this.rows; i++) {
      const row: any[] = [];
      for (let j = 0; j < this.cols; j++) {
        row.push({ selectedOption: 1, inputValue: '' });
      }
      console.log(row);
      this.gridData.push(row);
    }
  }

  generateFooterGrid() {
    this.showGrid = true;
    this.rowsFooterArray = Array.from({ length: this.footerRows });
    this.colsFooterArray = Array.from({ length: this.footerCols });

    this.gridFooterData = [];
    for (let i = 0; i < this.footerRows; i++) {
      const row: any[] = [];
      for (let j = 0; j < this.footerCols; j++) {
        row.push({ selectedOption: 1, inputValue: '' });
      }
      this.gridFooterData.push(row);
    }
  }

  getDataFromGrid(): void {
    console.log(this.gridData);
  }
  getdocumenttypeconfig() {
    this.loader.show();
   let objrequest: RequestContext={PageNumber:1,PageSize:1,Id:0};
      return this.doctypeservice.getdoctypeconfig(objrequest).subscribe((data: any) => {
        debugger
        this.typesDatasource = data.Response;
        debugger
        this.loader.hide();
        console.log(this.typesDatasource);
      }, (error:any) => {
        this.loader.hide();
      });
  }
}