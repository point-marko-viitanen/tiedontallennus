using Projetki_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projetki_App.Controllers
{
    public class HenkilotController : Controller
    {
        // GET: Henkilot
        public ActionResult Index()
        {
            ProjektiEntities entities = new ProjektiEntities();
            List<Henkilot> model = entities.Henkilot.ToList();
            entities.Dispose();
            return View(model);
        }
    }
}