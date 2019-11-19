using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace PattiFlow.Models
{
    public class FreightModel
    {
        public int InvoiceNo { get; set; }
        [DisplayName("Freight Amount")]
        public int FreightAmount { get; set; }

        [DisplayName("Freight Advance")]
        public int FreightAdvance { get; set; }

        [DisplayName("Freight Balance")]
        public int FreightBalance { get; set; }

        [DisplayName("Narration")]
        public string Narration { get; set; }
    }
}