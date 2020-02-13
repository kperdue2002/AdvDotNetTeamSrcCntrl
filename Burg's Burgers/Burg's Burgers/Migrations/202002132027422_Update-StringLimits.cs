namespace Burg_s_Burgers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateStringLimits : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "Address", c => c.String(nullable: false, maxLength: 64));
            AlterColumn("dbo.Orders", "City", c => c.String(nullable: false, maxLength: 32));
            AlterColumn("dbo.Orders", "State", c => c.String(maxLength: 2, unicode: false));
            AlterColumn("dbo.Orders", "ZipCode", c => c.String(nullable: false, maxLength: 5, unicode: false));
            AlterColumn("dbo.Orders", "PhoneNumber", c => c.String(maxLength: 16, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Orders", "ZipCode", c => c.String(nullable: false, maxLength: 8000, unicode: false));
            AlterColumn("dbo.Orders", "State", c => c.String(maxLength: 8000, unicode: false));
            AlterColumn("dbo.Orders", "City", c => c.String(nullable: false));
            AlterColumn("dbo.Orders", "Address", c => c.String(nullable: false));
        }
    }
}
