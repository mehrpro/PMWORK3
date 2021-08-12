﻿namespace PMWORK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateIdentityMachinery2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CompanyView",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CompnayIndex = c.Byte(nullable: false),
                        CompanyTitle = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CompanyView");
        }
    }
}
