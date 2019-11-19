using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PattiFlow.Models
{
    public class PurchaseModel
    {
        [DisplayName("Invoice No.")]
        public int InvoiceNo { get; set; }

        [DisplayName("Date")]
        public string Date { get; set; }

        [DisplayName("Lorry Type")]
        public string LorryType { get; set; }

        [DisplayName("Lorry No.")]
        public int LorryNo { get; set; }

        [DisplayName("Agent Name")]
        public string AgentName { get; set; }

        [DisplayName("Owners Name")]
        [Required]
        public string OwnersName { get; set; }

        [DisplayName("Farmer Name")]
        public string FarmerName { get; set; }

        [DisplayName("Address")]
        public string Address { get; set; }

        [DisplayName("Place")]
        public string Place { get; set; }

        [DisplayName("WayBill No.")]
        public int WayBillNo { get; set; }

        [DisplayName("Weigh Bridge Quantity")]
        public int WeighBridgeQuantity { get; set; }

        [DisplayName("Rate / Kgs")]
        public int Rate_Kgs { get; set; }

        [DisplayName("Weigh Bridge Less")]
        public bool WeighBridgeLess { get; set; }

        [DisplayName("Gunny Bag Weight")]
        public string gunnyBagWeight { get; set; }

        [DisplayName("Freight Voucher")]
        public bool HadFreightVoucher { get; set; }
    }
}