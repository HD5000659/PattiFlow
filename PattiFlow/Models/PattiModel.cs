using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PattiFlow.Models
{
    public class PattiModel
    {
        public int VoucherNumber { get; set; }

        public int PattiNumber { get; set; }

        public string Date { get; set; }

        public string AgentName { get; set; }

        public string AgentPlace { get; set; }

        public int AdvanceAmount { get; set; }

        public string Weighment { get; set; }

        public string WeighBridgeLess { get; set; }

        public string Gunnies { get; set; }

        public string PurchaseType { get; set; }

        public int BagWeight { get; set; }

        public string GunnyWeight { get; set; }

        public int CommPerBag { get; set; }

        public int RusumPerBag { get; set; }

        public int LessKg { get; set; }


    }
}