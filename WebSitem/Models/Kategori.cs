using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebSitem.Models
{
    [Table("Kategoriler")]
    public class Kategori
    {
        
        public int KategoriId { get; set; }

        public string KategoriAd { get; set; }

        public virtual ICollection<Urun> Urunler { get; set; }
    }
}