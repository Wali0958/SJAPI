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
    
    public partial class tbl_mst_HelpDeskUser
    {
        public string Redirect { get; set; }
        public long Gid { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Nullable<long> MobileNo { get; set; }
        public string LoginBrowser { get; set; }
        public string IPAddress { get; set; }
        public Nullable<System.DateTime> LastLog { get; set; }
        public string IsActive { get; set; }
        public Nullable<System.DateTime> RecInsTime { get; set; }
    }
}