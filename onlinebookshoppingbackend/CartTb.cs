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
    
    public partial class CartTb
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CartTb()
        {
            this.OrderTbs = new HashSet<OrderTb>();
        }
    
        public int CartId { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<int> UID { get; set; }
    
        public virtual UserTb UserTb { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderTb> OrderTbs { get; set; }
    }
}
