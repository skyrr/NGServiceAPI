namespace NGService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDelivery1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Deliveries",
                c => new
                    {
                        DeliveryId = c.Int(nullable: false, identity: true),
                        DeliveryBranchDispatchId = c.Int(nullable: false),
                        DeliveryDestinationBranchId = c.Int(nullable: false),
                        ServiceBranchDestinatin_BranchId = c.Int(),
                        ServiceBranchDispatch_BranchId = c.Int(),
                        ServiceBranch_BranchId = c.Int(),
                        ServiceBranch_BranchId1 = c.Int(),
                    })
                .PrimaryKey(t => t.DeliveryId)
                .ForeignKey("dbo.ServiceBranches", t => t.ServiceBranchDestinatin_BranchId)
                .ForeignKey("dbo.ServiceBranches", t => t.ServiceBranchDispatch_BranchId)
                .ForeignKey("dbo.ServiceBranches", t => t.ServiceBranch_BranchId)
                .ForeignKey("dbo.ServiceBranches", t => t.ServiceBranch_BranchId1)
                .Index(t => t.ServiceBranchDestinatin_BranchId)
                .Index(t => t.ServiceBranchDispatch_BranchId)
                .Index(t => t.ServiceBranch_BranchId)
                .Index(t => t.ServiceBranch_BranchId1);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Deliveries", "ServiceBranch_BranchId1", "dbo.ServiceBranches");
            DropForeignKey("dbo.Deliveries", "ServiceBranch_BranchId", "dbo.ServiceBranches");
            DropForeignKey("dbo.Deliveries", "ServiceBranchDispatch_BranchId", "dbo.ServiceBranches");
            DropForeignKey("dbo.Deliveries", "ServiceBranchDestinatin_BranchId", "dbo.ServiceBranches");
            DropIndex("dbo.Deliveries", new[] { "ServiceBranch_BranchId1" });
            DropIndex("dbo.Deliveries", new[] { "ServiceBranch_BranchId" });
            DropIndex("dbo.Deliveries", new[] { "ServiceBranchDispatch_BranchId" });
            DropIndex("dbo.Deliveries", new[] { "ServiceBranchDestinatin_BranchId" });
            DropTable("dbo.Deliveries");
        }
    }
}
