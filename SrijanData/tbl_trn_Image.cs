//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SrijanData
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_trn_Image
    {
        public long ImageID { get; set; }
        public string ImageName { get; set; }
        public string ImageType { get; set; }
        public Nullable<long> ImageActualSize { get; set; }
        public string ProductRefNo { get; set; }
        public string CompanyRefNo { get; set; }
        public Nullable<int> Priority { get; set; }
        public string IsActive { get; set; }
        public string IsApproved { get; set; }
        public string FType { get; set; }
        public Nullable<System.DateTime> RecInsTime { get; set; }
    }
}