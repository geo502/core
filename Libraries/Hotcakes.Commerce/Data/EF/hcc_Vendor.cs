//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotcakes.Commerce.Data.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class hcc_Vendor
    {
        public hcc_Vendor()
        {
            this.hcc_Product = new HashSet<hcc_Product>();
        }
    
        public System.Guid bvin { get; set; }
        public string DisplayName { get; set; }
        public string EmailAddress { get; set; }
        public string Address { get; set; }
        public string DropShipEmailTemplateId { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public long StoreId { get; set; }
    
        public virtual ICollection<hcc_Product> hcc_Product { get; set; }
    }
}