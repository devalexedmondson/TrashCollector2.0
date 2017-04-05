namespace TrashCollector2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletedAddressFK : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AspNetUsers", "AddressId", "dbo.Addresses");
            DropIndex("dbo.AspNetUsers", new[] { "AddressId" });
            DropColumn("dbo.AspNetUsers", "AddressId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "AddressId", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "AddressId");
            AddForeignKey("dbo.AspNetUsers", "AddressId", "dbo.Addresses", "Id");
        }
    }
}
