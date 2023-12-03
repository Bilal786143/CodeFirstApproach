namespace CodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.People", "age");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "age", c => c.Int(nullable: false));
        }
    }
}
