namespace WebSitem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ilk : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Urunler", "KategoriAd", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Urunler", "KategoriAd");
        }
    }
}
