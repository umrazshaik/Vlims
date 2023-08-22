import { Component, OnInit, ViewChild } from '@angular/core';
import { Location } from '@angular/common';

import { Router } from '@angular/router';
import { TemplateForm } from '../../models/templates';
import { DocumentTemplateConfiguration, DocumentTypeConfiguration, RequestContext } from 'src/app/models/model';
import { DocumentTypeServiceService } from 'src/app/modules/services/document-type-service.service';
import { NgxSpinnerService } from 'ngx-spinner';
import { CommonService } from 'src/app/shared/common.service';
import { DocumentTemplateServiceService } from 'src/app/modules/services/document-template-service.service';
import { ToastrService } from 'ngx-toastr';






interface SelectOption {
  name: string;
  value: number;
}
interface Page {
  text: string;
  pagenumber: number;
  pagetype: string;
  bodyData: BodyDataElement[][];
}
interface BodyDataElement {
  selectedOption: number;
  inputValue: string;
}
@Component({
  selector: 'app-add-template',
  templateUrl: './add-template.component.html',
  styleUrls: ['./add-template.component.scss'],
})
export class AddTemplateComponent implements OnInit {
  html = '';
  numOfPages: number = 1;
  pages: Page[] = [{ text: '', pagenumber: 1, pagetype: 'text', bodyData: [] }];
  currentPage: number = 0;
  id:number=0;
  title:string='New Document Template';
  typesDatasource: DocumentTypeConfiguration[] = [];
  selectedtype=new DocumentTypeConfiguration();
  templateForm=new DocumentTemplateConfiguration();
  grid:DocumentTemplateConfiguration[]=[];
  showGrid: boolean = false;
  rows: number = 0;
  cols: number = 0;
  headerRow:number=0;
  headerColumn:number=0;
  headerrowarray:number[]=[];
  headercolarray:number[]=[];
  rowsArray: number[] = [];
  colsArray: number[] = [];
  gridData: any = [];
  headerData:any=[];
  bodyData:any=[];
  footerRows: number = 0;
  footerCols: number = 0;
  rowsFooterArray: number[] = [];
  colsFooterArray: number[] = [];
  gridFooterData: any = [];

  selectOptions: SelectOption[] = [
    { name: 'Label', value: 1 },
     { name: 'Value', value: 2 },
    // { name: 'Property', value: 3 },
    // { name: 'Custom', value: 4 },
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

  constructor(private toastr: ToastrService,
    private location: Location,
    private doctypeservice:DocumentTypeServiceService,
    private loader:NgxSpinnerService,
    private commonsvc:CommonService,
    private templatesvc:DocumentTemplateServiceService,
    private router: Router
  ) {}

  ngOnInit(): void {
    const urlPath = this.router.url;
    const segments = urlPath.split('/');
    const lastSegment = segments[segments.length - 2];
    this.rows = 1;
    this.cols = 2;
    this.generateTeplateGrid();
    this.footerRows = 1;
    this.footerCols = 2;
    this.generateFooterGrid();
    this.headerRow=1;
    this.headerColumn=1;
    this.generateheaderrow();
    this.getTemplates();
    this.getdocumenttypeconfig();
    //  this.generateP();

    if(lastSegment=="add")
    {
     let addcount=parseInt(segments[segments.length - 1],10);
     addcount++;
    this.templateForm.Uniquecode="Temp "+addcount;  
    this.templateForm.Pages=1;
    }
    else if(lastSegment=="edit")
    {
      ;
      this.title='Edit Document Template';
      this.editMode=true;
        let id=parseInt(segments[segments.length-1],10);
        this.id=id;
        //this.getbyId(id);
    }
    else if(lastSegment=="view")
    {
      ;
      this.title='View Document Template';
      this.viewMode=true;
        let ide=segments[segments.length-1];
        this.getbyId(parseInt(segments[segments.length - 1]));
    }
    
  }
  generateP():BodyDataElement[] {
    
    const bodyData: BodyDataElement[] = [];
    for (let i = 0; i <1; i++) {
      const row: BodyDataElement[] = [];
      for (let j = 0; j < 4; j++) {
        if (j !== 0 && j % 2 !== 0)
        {
          row.push({ selectedOption: 2, inputValue: '' });
        }
        else {
        row.push({ selectedOption: 1, inputValue: '' });
        }
      }
      bodyData.push(...row);
    }
    console.log('data',bodyData);
    //this.pages[this.currentPage].bodyData=this.bodyData;
    return bodyData;
  }
  generateheaderrow() {
    
    this.showGrid = true;
    // Set the number of rows and columns based on user input
    // this.rows = 5;
    // this.cols = 5;
    this.headerrowarray = Array.from({ length: this.headerRow });
    this.headercolarray = Array.from({ length: this.headerColumn });
    this.headerData = [];
    for (let i = 0; i < this.headerRow; i++) {
      const row: any[] = [];
      for (let j = 0; j < this.headerColumn; j++) {
        if (j !== 0 && j % 2 !== 0)
        {
          row.push({ selectedOption: 2, inputValue: '' });
        }
        else {
        row.push({ selectedOption: 1, inputValue: '' });
        }
      }
      console.log(row);
      this.headerData.push(row);
    }
  }


  getbyId(id:number)
  {
    
    this.loader.show();
    this.templatesvc.getbyId(id).subscribe((data:any)=>{
      
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
      this.headerData=this.templateForm.titleTable;
      if(this.templateForm.Page!=null){
      this.pages=this.templateForm.Page;
      }
      console.log(this.templateForm);
      this.loader.hide();
    },(error:any)=>{

    });
  }
  getbyName(name:string)
  {
    
    this.loader.show();
    this.templatesvc.getdoctemplatebyname(name).subscribe((data:any)=>{
      
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
  getTemplates() {
    this.loader.show();
   //let objrequest: RequestContext={PageNumber:1,PageSize:100,Id:0};
      return this.templatesvc.getdocttemplate(this.commonsvc.req).subscribe((data: any) => {
        this.grid = data.Response;
        this.loader.hide();
      });
  }
  addTemplate() {
    
    this.loader.show();
    console.log(this.headerData);
    this.templateForm.documenttype=this.selectedtype.Documenttypename;
    this.templateForm.titleTable=this.headerData;
    this.templateForm.headerTable=this.gridData;
    this.templateForm.footerTable=this.gridFooterData;
    this.templateForm.rows=this.rowsArray.length.toString();
    this.templateForm.columns=this.colsArray.length.toString();
    this.templateForm.footerrows=this.rowsFooterArray.length.toString();
    this.templateForm.footercolumns=this.colsFooterArray.length.toString();
    this.templateForm.Page=this.pages;
    console.log(this.templateForm);
    if(this.editMode)
    {
      this.templateForm.ModifiedBy=this.commonsvc.getUsername();
      this.templatesvc.updatedoctemplate(this.templateForm).subscribe((data:any)=>{
        this.toastr.success('Document Template Updated Succesfull!', 'Updated.!');
      this.loader.hide();
      this.location.back();
    }, (error:any) => {
      this.loader.hide();
    });
    }
    else
    { 
      if(!this.isduplicate())
      {
        this.templateForm.CreatedBy=this.commonsvc.getUsername();
        this.templateForm.ModifiedBy=this.commonsvc.getUsername();
      this.templatesvc.adddoctemplate(this.templateForm).subscribe((data:any)=>{ 
        this.toastr.success('Document Template Saved Succesfull!', 'Saved.!');
        this.loader.hide();
        this.location.back();
      }, (error:any) => {
        this.loader.hide();
      });
    }
    }
    // this.templatesvc.adddoctemplate(this.templateForm).subscribe(() => {
    // this.router.navigate(['/templates']);
    // });
  }
  isduplicate() {
    if (this.grid != null && this.grid.length > 0) {
      const type = this.grid.find(p => p.Templatename == this.templateForm.Templatename);
      if (type != null || type != undefined) {
        this.toastr.error('Duplicate Entity');
        this.loader.hide();
        return true;
      } else {
        return false;
      }
    } else {
      return false;
    }
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
    if(this.cols % 2 !==0)
    {
      
      this.cols=this.cols+1;
    }
    this.gridData = [];
    for (let i = 0; i < this.rows; i++) {
      const row: any[] = [];
      for (let j = 0; j < this.cols; j++) {
        if (j !== 0 && j % 2 !== 0)
        {
          row.push({ selectedOption: 2, inputValue: '' });
        }
        else {
        row.push({ selectedOption: 1, inputValue: '' });
        }
      }
      console.log(row);
      this.gridData.push(row);
    }
  }
  addNewRow() {
    if (this.gridData.length > 0) {
      const lastRow = this.gridData[this.gridData.length - 1];
      const newRow = [...lastRow]; // Clone the last row's data

      // Apply your custom logic for the new row here
      newRow.forEach((cell, colIndex) => {
        if (colIndex !== 0 && colIndex % 2 !== 0) {
          newRow[colIndex] = { selectedOption: 2, inputValue: '' };
        } else {
          newRow[colIndex] = { selectedOption: 1, inputValue: '' };
        }
      });

      this.gridData.push(newRow);
    } else {
      // If no rows exist, generate a new row using your existing method
      this.generateTeplateGrid();
    }
  }
  addfooterRow() {
    if (this.gridFooterData.length > 0) {
      const lastRow = this.gridFooterData[this.gridFooterData.length - 1];
      const newRow = [...lastRow]; // Clone the last row's data

      // Apply your custom logic for the new row here
      newRow.forEach((cell, colIndex) => {
        if (colIndex !== 0 && colIndex % 2 !== 0) {
          newRow[colIndex] = { selectedOption: 2, inputValue: '' };
        } else {
          newRow[colIndex] = { selectedOption: 1, inputValue: '' };
        }
      });

      this.gridFooterData.push(newRow);
    } else {
      // If no rows exist, generate a new row using your existing method
      this.generateTeplateGrid();
    }
  }

  // Delete a row at the specified index from the gridData array
  deleteRow(rowIndex: number) {
    if(this.gridData.length>1){
    this.gridData.splice(rowIndex, 1);
    }
  }
  deletefooterRow(rowIndex: number) {
    if(this.gridFooterData.length>1){
    this.gridFooterData.splice(rowIndex, 1);
    }
  }
  deletebodyRow(rowIndex: number) {
    if(this.pages[this.currentPage].bodyData.length>1){
    this.pages[this.currentPage].bodyData.splice(rowIndex, 1);
    }
  }

  generateFooterGrid() {
    this.showGrid = true;
    this.rowsFooterArray = Array.from({ length: this.footerRows });
    this.colsFooterArray = Array.from({ length: this.footerCols });
    if(this.footerCols % 2 !==0)
    {
      
      this.footerCols=this.footerCols+1;
    }
    this.gridFooterData = [];
    for (let i = 0; i < this.footerRows; i++) {
      const row: any[] = [];
      for (let j = 0; j < this.footerCols; j++) {
        if (j !== 0 && j % 2 !== 0)
        {
          row.push({ selectedOption: 2, inputValue: '' });
        }
        else {
        row.push({ selectedOption: 1, inputValue: '' });
        }
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
        
        this.typesDatasource = data.Response;
        if(this.editMode){
          this.getbyId(this.id);
        }
        this.loader.hide();
        console.log(this.typesDatasource);
      }, (error:any) => {
        this.loader.hide();
      });
  }
  approve() {
    ;
    this.templateForm.Status = 'Approved'   
    this.templatesvc.updatedoctemplate(this.templateForm).subscribe((data:any)=>{
      this.loader.hide();
    }, (error:any) => {
      this.loader.hide();
    });
  }
  reinitiative() {
    this.templateForm.Status = 'Re-Initiated'    
    this.templatesvc.updatedoctemplate(this.templateForm).subscribe((data:any)=>{
      this.loader.hide();
    }, (error:any) => {
      this.loader.hide();
    });
  }
  reject() {
    this.templateForm.Status = 'Rejected'    
    this.templatesvc.updatedoctemplate(this.templateForm).subscribe((data:any)=>{
      this.loader.hide();
    }, (error:any) => {
      this.loader.hide();
    });
  }

  generatePages() {
    this.pages = Array.from({ length: this.templateForm.Pages }, (_, index) => (
      {
        text: '',
        pagenumber: index,
        pagetype: 'text',
        bodyData: [] // Initialize bodyData with an empty row
      }));
    this.currentPage = 0;
  }
  // Method to set the page type and bodyData for a specific page
setPageTypeAndBodyData(pageIndex: number, pageType: string) {
  
  if (pageType === 'grid') {
    this.pages[pageIndex].pagetype = 'grid';
    this.pages[pageIndex].bodyData.push(this.generateP());
    // if(this.pages[pageIndex].bodyData!=null){
    //   this.pages[pageIndex].bodyData.forEach(p=>{
    //     p.forEach(o=>{
    //       if(o.)
    //     })
    //   });
    // }
  } else {
    this.pages[pageIndex].pagetype = 'text';
    this.pages[pageIndex].bodyData = [];
  }
  console.log(this.pages);
}

  prevPage() {
    
    console.log(this.currentPage)
    if (this.currentPage > 0) {
      this.currentPage--;
    }
  }

  nextPage() {
    
    if (this.currentPage < this.templateForm.Pages - 1) {
      this.currentPage++;
    }
  }
  getPlaceholder(row: number, col: number): string {
    
    const flatIndex = row * 4 + col;
    return this.pages[this.currentPage].bodyData[flatIndex][col].selectedOption === 1
      ? 'Enter label'
      : 'Enter Value';
  }
  addbodyRow() {
    if (this.pages[this.currentPage].bodyData.length > 0) {
      const lastRow = this.pages[this.currentPage].bodyData[this.pages[this.currentPage].bodyData.length - 1];
      const newRow = [...lastRow]; // Clone the last row's data

      // Apply your custom logic for the new row here
      newRow.forEach((cell, colIndex) => {
        if (colIndex !== 0 && colIndex % 2 !== 0) {
          newRow[colIndex] = { selectedOption: 2, inputValue: '' };
        } else {
          newRow[colIndex] = { selectedOption: 1, inputValue: '' };
        }
      });

      this.pages[this.currentPage].bodyData.push(newRow);
    } else {
      // If no rows exist, generate a new row using your existing method
      //this.generateTeplateGrid();
    }
  }
}
