//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PattiFlow
{
    using System;
    using System.Collections.Generic;
    
    public partial class PurchaseOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PurchaseOrder()
        {
            this.PurchaseOrderItems = new HashSet<PurchaseOrderItem>();
        }
    
        public int ID { get; set; }
        public Nullable<int> InvoiceNo { get; set; }
        public string Date { get; set; }
        public string LorryType { get; set; }
        public Nullable<int> LorryNo { get; set; }
        public string AgentName { get; set; }
        public string OwnersName { get; set; }
        public string FarmerName { get; set; }
        public string Address { get; set; }
        public string Place { get; set; }
        public Nullable<int> WayBillNo { get; set; }
        public Nullable<int> WeighBridgeQuantity { get; set; }
        public Nullable<int> Rate_Kgs { get; set; }
        public Nullable<bool> WeighBridgeLess { get; set; }
        public Nullable<bool> HadFreightVoucher1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrderItem> PurchaseOrderItems { get; set; }
        public virtual FreightVoucher FreightVoucher { get; set; }
    }
}