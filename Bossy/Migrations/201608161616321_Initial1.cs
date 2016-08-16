namespace Bossy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        Category = c.String(),
                        TaskDesc = c.String(),
                        Note = c.String(),
                        Billable = c.Boolean(nullable: false),
                        EstTime = c.Int(nullable: false),
                        ActTIme = c.Int(nullable: false),
                        Group = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.Contacts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Zip = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ContactId);
            
            DropTable("dbo.Tasks");
        }
    }
}
