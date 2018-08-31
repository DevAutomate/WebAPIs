namespace APIOnline.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SPModel : DbContext
    {
        public SPModel()
            : base("name=SPModel")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<JobView> JobViews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.DepID)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.stat)
                .IsFixedLength()
                .IsUnicode(false);
        }

        internal object Add(Job job)
        {
            throw new NotImplementedException();
        }
    }
}
