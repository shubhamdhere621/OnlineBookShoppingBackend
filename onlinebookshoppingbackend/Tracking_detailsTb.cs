//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace onlinebookshoppingbackend
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tracking_detailsTb
    {
        public int Tracking_Id { get; set; }
        public Nullable<int> UID { get; set; }
        public Nullable<int> OrderId { get; set; }
        public string status { get; set; }
    
        public virtual OrderTb OrderTb { get; set; }
        public virtual UserTb UserTb { get; set; }
    }
}
