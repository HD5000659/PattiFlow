using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PattiFlow.Models
{
    public class AgentAdvanceModel
    {
        public int VoucherNumber { get; set; }

        public string Date { get; set; }

        public string AgentName { get; set; }

        public int AdvanceAmount { get; set; }

        public string Narration { get; set; }
    }
}