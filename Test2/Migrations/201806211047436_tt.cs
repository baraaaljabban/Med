namespace Test2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tt : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        DoctorId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.DoctorId);
            
            CreateTable(
                "dbo.ForginLaps",
                c => new
                    {
                        ForginLapId = c.Int(nullable: false, identity: true),
                        LapName = c.String(),
                    })
                .PrimaryKey(t => t.ForginLapId);
            
            CreateTable(
                "dbo.Patiants",
                c => new
                    {
                        PatiantId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        FatherName = c.String(),
                        Phome = c.String(),
                        Moblie = c.String(),
                        Mail = c.String(),
                        BirthDay = c.DateTime(nullable: false),
                        Title_TitleId = c.Int(),
                    })
                .PrimaryKey(t => t.PatiantId)
                .ForeignKey("dbo.Titles", t => t.Title_TitleId)
                .Index(t => t.Title_TitleId);
            
            CreateTable(
                "dbo.Titles",
                c => new
                    {
                        TitleId = c.Int(nullable: false, identity: true),
                        TitleName = c.String(),
                    })
                .PrimaryKey(t => t.TitleId);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        PaymentId = c.Int(nullable: false, identity: true),
                        PayMethod = c.String(),
                    })
                .PrimaryKey(t => t.PaymentId);
            
            CreateTable(
                "dbo.Settings",
                c => new
                    {
                        SettingId = c.Int(nullable: false, identity: true),
                        LapName = c.String(),
                        LapAddress = c.String(),
                        Phone = c.String(),
                        Notes = c.String(),
                        Unit_UnitId = c.Int(),
                    })
                .PrimaryKey(t => t.SettingId)
                .ForeignKey("dbo.Units", t => t.Unit_UnitId)
                .Index(t => t.Unit_UnitId);
            
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        UnitId = c.Int(nullable: false, identity: true),
                        UnitPrice = c.Int(nullable: false),
                        UnitName = c.String(),
                    })
                .PrimaryKey(t => t.UnitId);
            
            CreateTable(
                "dbo.TestesResults",
                c => new
                    {
                        TestResultId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Result = c.String(),
                        InForginLap = c.Boolean(nullable: false),
                        Notes = c.String(),
                        ForginLap_ForginLapId = c.Int(),
                        patiant_PatiantId = c.Int(),
                        Test_TestId = c.Int(),
                    })
                .PrimaryKey(t => t.TestResultId)
                .ForeignKey("dbo.ForginLaps", t => t.ForginLap_ForginLapId)
                .ForeignKey("dbo.Patiants", t => t.patiant_PatiantId)
                .ForeignKey("dbo.Tests", t => t.Test_TestId)
                .Index(t => t.ForginLap_ForginLapId)
                .Index(t => t.patiant_PatiantId)
                .Index(t => t.Test_TestId);
            
            CreateTable(
                "dbo.Tests",
                c => new
                    {
                        TestId = c.Int(nullable: false, identity: true),
                        TestCode = c.Int(nullable: false),
                        TestShortCut = c.String(),
                        UnitNumber = c.Int(nullable: false),
                        Notes = c.String(),
                        Unit_UnitId = c.Int(),
                    })
                .PrimaryKey(t => t.TestId)
                .ForeignKey("dbo.Units", t => t.Unit_UnitId)
                .Index(t => t.Unit_UnitId);
            
            CreateTable(
                "dbo.VisitInfoes",
                c => new
                    {
                        VisitInfoId = c.Int(nullable: false, identity: true),
                        ResultRecived = c.Boolean(nullable: false),
                        DiscountAmount = c.Int(nullable: false),
                        Title = c.String(),
                        Doctor_DoctorId = c.Int(),
                        patiant_PatiantId = c.Int(),
                        payment_PaymentId = c.Int(),
                        Unit_UnitId = c.Int(),
                    })
                .PrimaryKey(t => t.VisitInfoId)
                .ForeignKey("dbo.Doctors", t => t.Doctor_DoctorId)
                .ForeignKey("dbo.Patiants", t => t.patiant_PatiantId)
                .ForeignKey("dbo.Payments", t => t.payment_PaymentId)
                .ForeignKey("dbo.Units", t => t.Unit_UnitId)
                .Index(t => t.Doctor_DoctorId)
                .Index(t => t.patiant_PatiantId)
                .Index(t => t.payment_PaymentId)
                .Index(t => t.Unit_UnitId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VisitInfoes", "Unit_UnitId", "dbo.Units");
            DropForeignKey("dbo.VisitInfoes", "payment_PaymentId", "dbo.Payments");
            DropForeignKey("dbo.VisitInfoes", "patiant_PatiantId", "dbo.Patiants");
            DropForeignKey("dbo.VisitInfoes", "Doctor_DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.TestesResults", "Test_TestId", "dbo.Tests");
            DropForeignKey("dbo.Tests", "Unit_UnitId", "dbo.Units");
            DropForeignKey("dbo.TestesResults", "patiant_PatiantId", "dbo.Patiants");
            DropForeignKey("dbo.TestesResults", "ForginLap_ForginLapId", "dbo.ForginLaps");
            DropForeignKey("dbo.Settings", "Unit_UnitId", "dbo.Units");
            DropForeignKey("dbo.Patiants", "Title_TitleId", "dbo.Titles");
            DropIndex("dbo.VisitInfoes", new[] { "Unit_UnitId" });
            DropIndex("dbo.VisitInfoes", new[] { "payment_PaymentId" });
            DropIndex("dbo.VisitInfoes", new[] { "patiant_PatiantId" });
            DropIndex("dbo.VisitInfoes", new[] { "Doctor_DoctorId" });
            DropIndex("dbo.Tests", new[] { "Unit_UnitId" });
            DropIndex("dbo.TestesResults", new[] { "Test_TestId" });
            DropIndex("dbo.TestesResults", new[] { "patiant_PatiantId" });
            DropIndex("dbo.TestesResults", new[] { "ForginLap_ForginLapId" });
            DropIndex("dbo.Settings", new[] { "Unit_UnitId" });
            DropIndex("dbo.Patiants", new[] { "Title_TitleId" });
            DropTable("dbo.VisitInfoes");
            DropTable("dbo.Tests");
            DropTable("dbo.TestesResults");
            DropTable("dbo.Units");
            DropTable("dbo.Settings");
            DropTable("dbo.Payments");
            DropTable("dbo.Titles");
            DropTable("dbo.Patiants");
            DropTable("dbo.ForginLaps");
            DropTable("dbo.Doctors");
        }
    }
}
