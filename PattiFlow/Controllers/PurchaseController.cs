using PattiFlow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;

namespace PattiFlow.Controllers
{
    public class PurchaseController : Controller
    {
        private PattiFlowEntities db = new PattiFlowEntities();
        // GET: Purchase
        public ActionResult Index()

        {
            ViewBag.Agents = db.Agents.Select(m => m.AgentName).ToList();
            ViewBag.LorryType = new List<string>() { "Own", "Outside" };
            ViewBag.LorryNumber = new List<int>() { 1234, 5678 };
            ViewBag.RateKg = new List<int>() { 75, 78, 100 };
            ViewBag.WeighBridgeLess = new List<string> { "Yes", "No" };
            ViewBag.GunnyBagWeight = new List<string> { "0.8", "1" };
            var model = new PurchaseViewModel()
            {
                PurchaseModel = new PurchaseModel() { Date = DateTime.Now.ToShortDateString() }
            };
            var c = new Random();
            model.PurchaseModel.InvoiceNo = c.Next(100, 999);
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(PurchaseViewModel model, string AgentName, int? LorryNo, string LorryType, int? Rate_Kgs, string gunnyBagWeight, string WeighBridgeLess)
        {
            if (model.FreightModel == null)
            {
                model.PurchaseModel.AgentName = AgentName;
                model.PurchaseModel.LorryNo = LorryNo ?? 0;
                model.PurchaseModel.LorryType = LorryType;
                model.PurchaseModel.Rate_Kgs = Rate_Kgs ?? 0;
                model.PurchaseModel.gunnyBagWeight = gunnyBagWeight;
                model.PurchaseModel.WeighBridgeLess = WeighBridgeLess == "Yes" ? true : false;
                var config = new MapperConfiguration(cfg => cfg.CreateMap<PurchaseModel, PurchaseOrder>());
                var mapper = config.CreateMapper();
                var dto = mapper.Map<PurchaseOrder>(model.PurchaseModel);
                db.PurchaseOrders.Add(dto);
                db.SaveChanges();
                Session["PurchaseId"] = dto.ID;

            }
            else
            {


            }
            return RedirectToAction("Index");


        }


        [HttpPost]
        public ActionResult SavePurchaseOrderItems(List<PurchaseOrderItem> things)
        {
            foreach (var thing in things)
            {
                db.PurchaseOrderItems.Add(thing);
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult SaveFreightData(string FreightAmount, string FreightAdvance, string FreightBalance, string Narration)
        {
            var model = new PurchaseViewModel()
            {
                FreightModel = new FreightModel()
            };
            model.FreightModel.InvoiceNo = Convert.ToInt32(Session["PurchaseId"]);
            model.FreightModel.FreightAmount = Convert.ToInt32(FreightAmount);
            model.FreightModel.FreightAdvance = Convert.ToInt32(FreightAdvance);
            model.FreightModel.FreightBalance = Convert.ToInt32(FreightBalance);
            model.FreightModel.Narration = Narration;
            var config = new MapperConfiguration(cfg => cfg.CreateMap<FreightModel, FreightVoucher>());
            var mapper = config.CreateMapper();
            var dto = mapper.Map<FreightVoucher>(model.FreightModel);
            db.FreightVouchers.Add(dto);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}