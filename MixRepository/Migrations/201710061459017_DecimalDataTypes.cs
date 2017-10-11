namespace MixRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DecimalDataTypes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Mixes", "CFx", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Mixes", "SVO", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Mixes", "Carbon", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Mixes", "Binder", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Mixes", "Binder", c => c.Int(nullable: false));
            AlterColumn("dbo.Mixes", "Carbon", c => c.Int(nullable: false));
            AlterColumn("dbo.Mixes", "SVO", c => c.Int(nullable: false));
            AlterColumn("dbo.Mixes", "CFx", c => c.Int(nullable: false));
        }
    }
}
