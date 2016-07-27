using System.Data.Entity;

namespace PiggyBankCore.Domain
{
    public class PiggyBankContext:DbContext 
    {
        public PiggyBankContext():base()
        { }

        public DbSet<FamilyMember> FamilyMembers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Operation> Operations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");

            modelBuilder.Entity<FamilyMember>().ToTable("FamilyMember");
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Operation>().ToTable("Operation");

            modelBuilder.Entity<Operation>().Property(p => p.Date).HasColumnName("Operation_Date");
            modelBuilder.Entity<Operation>().Property(p => p.FamilyMemberId).HasColumnName("ID_FamilyMember");
            modelBuilder.Entity<Operation>().Property(p => p.CategoryId).HasColumnName("ID_Category");
            modelBuilder.Entity<Operation>().Property(p => p.Status).HasColumnName("ID_OperationType");

            modelBuilder.Entity<Operation>().HasRequired<FamilyMember>(x => x.FamilyMember).WithMany(o => o.Operations).HasForeignKey(f => f.FamilyMemberId);
            modelBuilder.Entity<Operation>().HasRequired<Category>(x => x.Category).WithMany(o => o.Operations).HasForeignKey(c => c.CategoryId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
