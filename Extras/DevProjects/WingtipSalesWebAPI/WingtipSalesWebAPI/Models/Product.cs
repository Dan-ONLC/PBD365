//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WingtipSalesWebAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.InvoiceDetails = new HashSet<InvoiceDetail>();
        }
    
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ProductCategory { get; set; }
        public Nullable<decimal> UnitCost { get; set; }
        public Nullable<decimal> ListPrice { get; set; }
        public string Color { get; set; }
        public Nullable<int> MinimumAge { get; set; }
        public Nullable<int> MaximumAge { get; set; }
        public string ProductImageUrl { get; set; }
        public byte[] ProductImage { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
    }
}