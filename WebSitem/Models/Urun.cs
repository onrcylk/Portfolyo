using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebSitem.Models
{
    [Table("Urunler")]
    public class Urun
    {
        public int UrunId { get; set; }
        [ForeignKey("Kategori")]
        public int KategoriId { get; set; }
        public int KategoriAd { get; set; }
        public string UrunAd { get; set; }
        public int UrunAdet { get; set; }

        public virtual Kategori Kategori { get; set; }
    }
}