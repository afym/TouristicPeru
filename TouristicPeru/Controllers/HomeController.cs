using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using TouristicPeru.Models.Domain.Entity;
using TouristicPeru.Models.Infraestructure.Repository;

namespace TouristicPeru.Controllers
{
    public class HomeController : Controller
    {
        private PointStaticRepository PointRepository;

        public HomeController() 
        {
            this.PointRepository = new PointStaticRepository();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetPoints() 
        {
            return Json(new { error = false, data = this.PointRepository.FindAll() }, JsonRequestBehavior.AllowGet);
        }
    }
}