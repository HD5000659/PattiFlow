using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace PattiFlow.Models
{
    public class RatesModel
    {
        public string Date { get; set; }
        [DisplayName("Invoice No.")]
        public Nullable<int> InvoiceNo { get; set; }
        [DisplayName("Item Name")]
        public string ItemDescription { get; set; }
        [DisplayName("No Of Gunnies")]
        public Nullable<int> NumberOfGunnies { get; set; }
        [DisplayName("Bag Weight")]
        public Nullable<int> BagWeight { get; set; }
        [DisplayName("Net Weight")]
        public Nullable<int> NetWeight { get; set; }
        public Nullable<int> Rate { get; set; }
        public Nullable<int> Amount { get; set; }
    }
}