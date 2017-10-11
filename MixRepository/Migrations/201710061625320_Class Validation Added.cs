namespace MixRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClassValidationAdded : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Mixes", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Mixes", "Name", c => c.String());
        }
    }
}
