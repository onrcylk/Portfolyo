using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSitem.Models;

namespace WebSitem.Controllers
{
    public class MusteriController : Controller
    {
        WebSitemContext db = new WebSitemContext();
        // GET: Musteri
        public ActionResult Index()
        {
            List<Musteri> Musteriler = db.Musteriler.ToList();
            return View(Musteriler);
        }
    }
}