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
            List<Musteri> musteri= db.Musteriler.ToList();
            ViewBag.Musteri = db.Musteriler.ToList();
            return View();
        }
        public ActionResult MusteriEkle(int? id)
        {
            List<Musteri> musteri = db.Musteriler.ToList();
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MusteriEkle(Musteri musteri)
        {
            ViewBag.Musteri = db.Musteriler.ToList();
            if (ModelState.IsValid)
            {
                db.Musteriler.Add(musteri);
                db.SaveChanges();
              return RedirectToAction("Index");
            }
            return View();
        }
    }
}