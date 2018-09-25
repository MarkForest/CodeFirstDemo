namespace CodeFirstDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingCitytable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Publishers", "CityId", c => c.Int(nullable: false));
            CreateIndex("dbo.Publishers", "CityId");
            AddForeignKey("dbo.Publishers", "CityId", "dbo.Cities", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Publishers", "CityId", "dbo.Cities");
            DropIndex("dbo.Publishers", new[] { "CityId" });
            DropColumn("dbo.Publishers", "CityId");
            DropTable("dbo.Cities");
        }
    }
}
