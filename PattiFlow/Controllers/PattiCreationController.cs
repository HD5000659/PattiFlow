using AutoMapper;
using PattiFlow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PattiFlow.Controllers
{
    public class PattiCreationController : Controller
    {

        private PattiFlowEntities db = new PattiFlowEntities();
        // GET: PattiCreation
        public ActionResult Index()
        {
            ViewBag.Agents = db.Agents.Select(m => m.AgentName).ToList();
            ViewBag.Weighment = new List<string>() { "Weigh Bridge", "Bag Weight" };
            ViewBag.WeighBridgeLess = new List<string>() { "Yes", "No" };
            ViewBag.Gunnies = new List<string>() { "With Gunnies", "Without Gunnies" };
            ViewBag.PurchaseType = new List<string>() { "With Freight", "Without Freight" };
            ViewBag.BagWeight = new List<string>() { "75", "76", "100" };
            ViewBag.GunnyWeight = new List<string>() { "0.8", "1" };
            var c = new Random();
            var model = new PattiCreation()
            {
                VoucherNumber = c.Next(100, 999),
                PattiNumber = c.Next(100, 999),
                Date = DateTime.Now.ToShortDateString()
            };
            return View(model);
        }

        [HttpGet]
        public ActionResult GetData(string agentName)
        {
            var output = new PattiModel();
            IList<PattiItem> final = new List<PattiItem>();
            var model = db.PurchaseOrders.Where(x => x.AgentName.Equals(agentName)).ToList().Select(y => y.ID);
            foreach (var id in model)
            {
                var order = db.PurchaseOrders.Where(x => x.ID == id).First();
                var purchaseOrderItems = db.PurchaseOrderItems.Where(x => x.PurchaseOrderId == id && x.ItemType == "paddy").ToList();
                foreach (var item in purchaseOrderItems)
                {
                    var pattiItem = new PattiItem()
                    {
                        VoucherNumber = item.PurchaseOrder.InvoiceNo??0,
                        Date = item.PurchaseOrder.Date,
                        NumberOfGunnies = item.NumberOfBags,
                        RateInBags = item.Rate,
                        WeighmentIn = item.NetWeight.ToString(),
                        TotalFreight = order.FreightVoucher!=null?Convert.ToInt32(order.FreightVoucher.FreightAmount):0,
                        AdvanceFreight = order.FreightVoucher!=null?Convert.ToInt32(order.FreightVoucher.FreightAdvance):0,                       
                    };
                    final.Add(pattiItem);
                }
            }
            return Json(final, JsonRequestBehavior.AllowGet);
        }



        [HttpPost]
        public ActionResult Index(PattiModel model)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<PattiModel, PattiCreation>());
            var mapper = config.CreateMapper();
            var dto = mapper.Map<PattiCreation>(model);
            db.PattiCreations.Add(dto);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult SavePattiItems(List<PattiItem> things)
        {
            foreach (var thing in things)
            {
                db.PattiItems.Add(thing);
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}