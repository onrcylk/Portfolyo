namespace WebSitem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ilk : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategoriler",
                c => new
                    {
                        KategoriId = c.Int(nullable: false, identity: true),
                        KategoriAd = c.String(),
                    })
                .PrimaryKey(t => t.KategoriId);
            
            CreateTable(
                "dbo.Urunler",
                c => new
                    {
                        UrunId = c.Int(nullable: false, identity: true),
                        KategoriId = c.Int(nullable: false),
                        KategoriAd = c.Int(nullable: false),
                        UrunAd = c.String(),
                        UrunAdet = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UrunId)
                .ForeignKey("dbo.Kategoriler", t => t.KategoriId, cascadeDelete: true)
                .Index(t => t.KategoriId);
            
            CreateTable(
                "dbo.Musteri",
                c => new
                    {
                        MusteriId = c.Int(nullable: false, identity: true),
                        MusteriAd = c.String(),
                        MusteriSoyad = c.String(),
                    })
                .PrimaryKey(t => t.MusteriId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Urunler", "KategoriId", "dbo.Kategoriler");
            DropIndex("dbo.Urunler", new[] { "KategoriId" });
            DropTable("dbo.Musteri");
            DropTable("dbo.Urunler");
            DropTable("dbo.Kategoriler");
        }
    }
}
