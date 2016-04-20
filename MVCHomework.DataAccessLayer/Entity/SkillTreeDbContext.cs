namespace MVCHomework.DataAccessLayer.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SkillTreeDbContext : DbContext
    {
        public SkillTreeDbContext()
            : base("name=SkillTreeDbContext")
        {
        }

        public virtual DbSet<AccountBook> AccountBook { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
