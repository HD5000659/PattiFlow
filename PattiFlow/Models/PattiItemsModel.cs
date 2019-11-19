using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PattiFlow.Models
{
    public class PattiItemsModel
    {
        public int Vouchernumber { get; set; }

        public string Date { get; set; }

        public int ItemNumber { get; set; }

        public int NumberOfGunnies { get; set; }

        public int BagWeight { get; set; }

        public int WeightInBags { get; set; }

        public string WeighBridge { get; set; }

        public string WeighmentLess { get; set; }

        public string WeighmentIn { get; set; }

        public int Shortage { get; set; }

        public int ShortageAmount { get; set; }

        public int RateInBags { get; set; }

        public int TotalFreight { get; set; }

        public int AdvanceFreight { get; set; }

        public int CommissionAmount { get; set; }

        public int RusumAmount { get; set; }

        public int PayableAmount { get; set; }
    }
}