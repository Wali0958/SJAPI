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
    
    public partial class tbl_trn_VendorDetailofDefence
    {
        public long VDetailDefenceId { get; set; }
        public string VendorRefNo { get; set; }
        public string ProductNomenClature { get; set; }
        public Nullable<long> NatoGroup { get; set; }
        public Nullable<long> NatoClass { get; set; }
        public Nullable<long> ItemCode { get; set; }
        public Nullable<long> Technology { get; set; }
        public Nullable<long> SubTechnology { get; set; }
        public Nullable<long> HSNCode { get; set; }
        public string IsActive { get; set; }
        public Nullable<System.DateTime> RecInsTime { get; set; }
        public Nullable<System.DateTime> LastUpdate { get; set; }
    }
}