//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Survey_API.EFModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Questions
    {
        public int id { get; set; }
        public string itemScript { get; set; }
        public Nullable<System.DateTime> createdDate { get; set; }
        public Nullable<int> state { get; set; }
        public string status { get; set; }
        public string createdBy { get; set; }
    }
}