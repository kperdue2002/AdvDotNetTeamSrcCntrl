namespace Burg_s_Burgers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Order : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50, unicode: false),
                        LastName = c.String(nullable: false, maxLength: 50, unicode: false),
                        Address = c.String(nullable: false),
                        City = c.String(nullable: false),
                        State = c.String(maxLength: 8000, unicode: false),
                        ZipCode = c.String(nullable: false, maxLength: 8000, unicode: false),
                        PhoneNumber = c.String(),
                        Quantity = c.Byte(nullable: false),
                        SpecialDirections = c.String(maxLength: 512),
                        DateOfOrder = c.DateTime(nullable: false),
                        IsDelivered = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Orders");
        }
    }
}
