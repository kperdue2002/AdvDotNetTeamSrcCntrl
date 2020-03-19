namespace Burg_s_Burgers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StateRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "State", c => c.String(nullable: false, maxLength: 2, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "State", c => c.String(maxLength: 2, unicode: false));
        }
    }
}
