//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vlims.DocumentMaster.Entities
{
    using System;
    using System.Collections.Generic;



    // Comment
    public class DocumentTemplateConfiguration
    {

        private string dtidField;

        private string documentmasteridField;

        private string templatenameField;

        private string uniquecodeField;

        private string documenttypeField;

        private string headerField;

        private string rowsField;

        private string columnsField;

        private string footerField;

        //private string rowsField;

        //private string columnsField;

        private string createdbyField;

        private DateTime? createddateField;

        private string modifiedbyField;

        private DateTime? modifieddateField;

        public string DTID
        {
            get
            {
                return this.dtidField;
            }
            set
            {
                this.dtidField = value;
            }
        }

        public string DocumentMasterId
        {
            get
            {
                return this.documentmasteridField;
            }
            set
            {
                this.documentmasteridField = value;
            }
        }

        public string Templatename
        {
            get
            {
                return this.templatenameField;
            }
            set
            {
                this.templatenameField = value;
            }
        }

        public string Uniquecode
        {
            get
            {
                return this.uniquecodeField;
            }
            set
            {
                this.uniquecodeField = value;
            }
        }

        public string documenttype
        {
            get
            {
                return this.documenttypeField;
            }
            set
            {
                this.documenttypeField = value;
            }
        }

        public string header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }

        public string rows
        {
            get
            {
                return this.rowsField;
            }
            set
            {
                this.rowsField = value;
            }
        }

        public string columns
        {
            get
            {
                return this.columnsField;
            }
            set
            {
                this.columnsField = value;
            }
        }

        public string footer
        {
            get
            {
                return this.footerField;
            }
            set
            {
                this.footerField = value;
            }
        }
        public string footerrows { get; set; }
        public string footercolumns { get; set; }
        //public string rows
        //{
        //    get
        //    {
        //        return this.rowsField;
        //    }
        //    set
        //    {
        //        this.rowsField = value;
        //    }
        //}

        //public string columns
        //{
        //    get
        //    {
        //        return this.columnsField;
        //    }
        //    set
        //    {
        //        this.columnsField = value;
        //    }
        //}

        public string CreatedBy
        {
            get
            {
                return this.createdbyField;
            }
            set
            {
                this.createdbyField = value;
            }
        }

        public DateTime? CreatedDate
        {
            get
            {
                return this.createddateField;
            }
            set
            {
                this.createddateField = value;
            }
        }

        public string ModifiedBy
        {
            get
            {
                return this.modifiedbyField;
            }
            set
            {
                this.modifiedbyField = value;
            }
        }

        public DateTime? ModifiedDate
        {
            get
            {
                return this.modifieddateField;
            }
            set
            {
                this.modifieddateField = value;
            }
        }
    }
}
