//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vlims.Entities
{
    using System;
    using System.Collections.Generic;
  
    
    
    // Comment
    public class AdditionalTask
    {
        
        private string atidField;
        
        private string documentmanageridField;
        
        private string createdbyField;
        
        private DateTime? createddateField;
        
        private string modifiedbyField;
        
        private DateTime? modifieddateField;
        
        public string ATID
        {
            get
            {
                return this.atidField;
            }
            set
            {
                this.atidField = value;
            }
        }
        
        public string Documentmanagerid
        {
            get
            {
                return this.documentmanageridField;
            }
            set
            {
                this.documentmanageridField = value;
            }
        }
        
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
