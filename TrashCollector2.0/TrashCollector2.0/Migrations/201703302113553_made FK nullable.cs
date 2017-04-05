namespace TrashCollector2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class madeFKnullable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AspNetUsers", "AddressId", "dbo.Addresses");
            DropForeignKey("dbo.AspNetUsers", "PickUpOptionId", "dbo.PickUpOptions");
            DropIndex("dbo.AspNetUsers", new[] { "AddressId" });
            DropIndex("dbo.AspNetUsers", new[] { "PickUpOptionId" });
            AlterColumn("dbo.AspNetUsers", "AddressId", c => c.Int());
            AlterColumn("dbo.AspNetUsers", "PickUpOptionId", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "AddressId");
            CreateIndex("dbo.AspNetUsers", "PickUpOptionId");
            AddForeignKey("dbo.AspNetUsers", "AddressId", "dbo.Addresses", "Id");
            AddForeignKey("dbo.AspNetUsers", "PickUpOptionId", "dbo.PickUpOptions", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "PickUpOptionId", "dbo.PickUpOptions");
            DropForeignKey("dbo.AspNetUsers", "AddressId", "dbo.Addresses");
            DropIndex("dbo.AspNetUsers", new[] { "PickUpOptionId" });
            DropIndex("dbo.AspNetUsers", new[] { "AddressId" });
            AlterColumn("dbo.AspNetUsers", "PickUpOptionId", c => c.Int(nullable: false));
            AlterColumn("dbo.AspNetUsers", "AddressId", c => c.Int(nullable: false));
            CreateIndex("dbo.AspNetUsers", "PickUpOptionId");
            CreateIndex("dbo.AspNetUsers", "AddressId");
            AddForeignKey("dbo.AspNetUsers", "PickUpOptionId", "dbo.PickUpOptions", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AspNetUsers", "AddressId", "dbo.Addresses", "Id", cascadeDelete: true);
        }
    }
}
