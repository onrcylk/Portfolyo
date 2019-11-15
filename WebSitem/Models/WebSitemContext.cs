using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebSitem.Models
{
    public class WebSitemContext:DbContext
    {
        public WebSitemContext(): base("name=Baglan")
        {


        }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }

    }
}