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
    
    public partial class PattiItem
    {
        public int Id { get; set; }
        public int VoucherNumber { get; set; }
        public string Date { get; set; }
        public Nullable<int> ItemNumber { get; set; }
        public Nullable<int> NumberOfGunnies { get; set; }
        public Nullable<int> BagWeight { get; set; }
        public Nullable<int> WeightInBags { get; set; }
        public string WeighBridge { get; set; }
        public string WeighmentLess { get; set; }
        public string WeighmentIn { get; set; }
        public Nullable<int> Shortage { get; set; }
        public Nullable<int> ShortageAmount { get; set; }
        public Nullable<int> RateInBags { get; set; }
        public Nullable<int> TotalFreight { get; set; }
        public Nullable<int> AdvanceFreight { get; set; }
        public Nullable<int> CommissionAmount { get; set; }
        public Nullable<int> RusumAmount { get; set; }
        public Nullable<int> PayableAmount { get; set; }
    }
}