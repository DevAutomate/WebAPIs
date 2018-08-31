namespace APIOnline.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CRMModel : DbContext
    {
        public CRMModel()
            : base("name=CRMModel")
        {
        }

        public virtual DbSet<tblCustomer> tblCustomers { get; set; }
        public virtual DbSet<tblCusBilling> tblCusBillings { get; set; }
        public virtual DbSet<tblCusContact> tblCusContacts { get; set; }
        public virtual DbSet<tblOriginDestination> tblOriginDestinations { get; set; }
        public virtual DbSet<tblP> tblPS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblP>()
                .Property(e => e.CusID)
                .IsUnicode(false);

            modelBuilder.Entity<tblP>()
                .Property(e => e.PSRefNo)
                .IsUnicode(false);

            modelBuilder.Entity<tblP>()
                .Property(e => e.Plot)
                .IsUnicode(false);

            modelBuilder.Entity<tblP>()
                .Property(e => e.PSId)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
