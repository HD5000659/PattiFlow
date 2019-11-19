using PattiFlow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;

namespace PattiFlow.Controllers
{
    public class RatesController : Controller
    {
        private PattiFlowEntities db = new PattiFlowEntities();
        public ActionResult Index()
        {
            ViewBag.Agents = db.Agents.Select(m => m.AgentName).ToList();
            return View();
        }
     

        public ActionResult GetData(string agentName, string place)
        {
            IList<PurchaseOrder> model = new List<PurchaseOrder>();
            if (!string.IsNullOrEmpty(agentName) && !string.IsNullOrEmpty(place))
                model = db.PurchaseOrders.Where(x => x.AgentName.Equals(agentName) && x.Place.Equals(place)).ToList();
            else
                model = db.PurchaseOrders.ToList();
            IList<RatesModel> output = new List<RatesModel>();
            foreach(PurchaseOrder order in model)
            {
                foreach(PurchaseOrderItem orderItem in order.PurchaseOrderItems)
                {
                    var ratesModel = new RatesModel() {
                        Date = order.Date,
                        InvoiceNo = order.InvoiceNo,
                        ItemDescription = orderItem.ItemDescription,
                        NumberOfGunnies = orderItem.NumberOfGunnies,
                        BagWeight = orderItem.BagWeight,
                        NetWeight = orderItem.NetWeight,
                        Rate = orderItem.Rate,
                        Amount = orderItem.Amount
                    };
                    output.Add(ratesModel);
                }               

            }

            return Json(output, JsonRequestBehavior.AllowGet);
        }
    }
}