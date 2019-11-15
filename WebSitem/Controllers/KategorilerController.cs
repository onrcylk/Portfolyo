using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebSitem.Models;

namespace WebSitem.Controllers
{
    public class KategorilerController : Controller
    {
        // GET: Kategoriler
        WebSitemContext db = new WebSitemContext();
        public ActionResult Index()
        {
            List<Kategori> kategoris = db.Kategoriler.ToList();
            ViewBag.Ktg = kategoris;
            return View();
        }
        public ActionResult KtgEkle(int? id)
        {
            List<Kategori> kategoris = db.Kategoriler.ToList();
         
            return View();
           
        }
        [HttpPost]
       
        public ActionResult KtgEkle(Kategori kategori)
        {
            if (ModelState.IsValid)
            {
                db.Kategoriler.Add(kategori);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();

        }
        public ActionResult KtgSil(int? id)
        {
            Kategori kategori = db.Kategoriler.Find(id);
            
            return View();
        }


        [HttpPost]
        public ActionResult KtgSil(int id)
        {
            Kategori kategori = db.Kategoriler.Find(id);
            db.Kategoriler.Remove(kategori);
            db.SaveChanges();

            return RedirectToAction("Index");

        }
       

    }
}