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
    
    public partial class tbl_ExceptionLoggingToDataBase
    {
        public long LogId { get; set; }
        public string ExceptionMsg { get; set; }
        public string ExceptionType { get; set; }
        public string ExceptionSource { get; set; }
        public string ExceptionURL { get; set; }
        public Nullable<System.DateTime> Logdate { get; set; }
        public string IPAddress { get; set; }
        public string Browser { get; set; }
    }
}
