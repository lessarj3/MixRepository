namespace MixRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RatiosColumnAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mixes", "Ratio", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Mixes", "Ratio");
        }
    }
}
