namespace Futronic.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AttendanceLogs",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        UserId = c.Long(nullable: false),
                        RecordDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        UserName = c.String(nullable: false),
                        LeftHand_Id = c.Long(),
                        RightHand_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FingerPrints", t => t.LeftHand_Id)
                .ForeignKey("dbo.FingerPrints", t => t.RightHand_Id)
                .Index(t => t.LeftHand_Id)
                .Index(t => t.RightHand_Id);
            
            CreateTable(
                "dbo.FingerPrints",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Thumb = c.Binary(),
                        IndexFinger = c.Binary(),
                        MiddleFinger = c.Binary(),
                        RingFinger = c.Binary(),
                        LittleFinger = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "RightHand_Id", "dbo.FingerPrints");
            DropForeignKey("dbo.Users", "LeftHand_Id", "dbo.FingerPrints");
            DropForeignKey("dbo.AttendanceLogs", "UserId", "dbo.Users");
            DropIndex("dbo.Users", new[] { "RightHand_Id" });
            DropIndex("dbo.Users", new[] { "LeftHand_Id" });
            DropIndex("dbo.AttendanceLogs", new[] { "UserId" });
            DropTable("dbo.FingerPrints");
            DropTable("dbo.Users");
            DropTable("dbo.AttendanceLogs");
        }
    }
}
