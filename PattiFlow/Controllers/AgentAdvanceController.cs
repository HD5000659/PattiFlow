using AutoMapper;
using PattiFlow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PattiFlow.Controllers
{
    public class AgentAdvanceController : Controller
    {
        private PattiFlowEntities db = new PattiFlowEntities();
        // GET: AgentAdvance
        public ActionResult Index()
        {
            ViewBag.Agents = db.Agents.Select(m => m.AgentName).ToList();
            var c = new Random();
            var model = new AgentAdvance()
            {
                VoucherNumber = c.Next(100, 999),
                Date = DateTime.Now.ToShortDateString()
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult SaveAgentAdvanceData(AgentAdvanceModel model)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<AgentAdvanceModel, AgentAdvance>());
            var mapper = config.CreateMapper();
            var dto = mapper.Map<AgentAdvance>(model);
            db.AgentAdvances.Add(dto);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
    
}