namespace Projekat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTipPttAdrese : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO TipPttAdrese (TipAdrese) VALUES ('Kuca')");
            Sql("INSERT INTO TipPttAdrese (TipAdrese) VALUES ('Posao')");
            Sql("INSERT INTO TipPttAdrese (TipAdrese) VALUES ('Adresa iz LK')");

        }
        
        public override void Down()
        {
        }
    }
}
