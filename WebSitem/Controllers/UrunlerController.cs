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
    public class UrunlerController : Controller
    {
        WebSitemContext db = new WebSitemContext();
        // GET: Urunler
        public ActionResult Index()
        {
            List<Kategori> kategoris = db.Kategoriler.ToList();
            ViewBag.Ktg = kategoris;
            List<Urun> Urunler = db.Urunler.ToList();
            ViewBag.UrunEkle = Urunler;
            return View();
        }

        public ActionResult UrunEkle()
        {
            List<Kategori> kategoris = db.Kategoriler.ToList();
            ViewBag.Ktg = kategoris;
            List<Urun> uruns = db.Urunler.ToList();
            ViewBag.UrunEkle = uruns;
            return View();

        }

        [HttpPost]
        public ActionResult UrunEkle(string urunAd, int urunAdet, int kId)
        {
            Urun u = new Urun();
            u.UrunAd = urunAd;
            u.UrunAdet = urunAdet;
            u.KategoriId = kId;
            db.Urunler.Add(u);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult Sil(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Urun urun = db.Urunler.Find(id);

            if (urun == null)
            {
                return HttpNotFound();
            }

            return View(urun);
        }


        [HttpPost]
        public ActionResult Sil(int id)
        {
            Urun urun = db.Urunler.Find(id);
            db.Urunler.Remove(urun);
            db.SaveChanges();

            return RedirectToAction("Index");

        }



    }
}