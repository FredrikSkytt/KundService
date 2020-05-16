namespace KundService
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class KundModel : DbContext
    {
        public KundModel()
            : base("name=KundModel")
        {
        }

        public virtual DbSet<Kund> Kund { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kund>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Kund>()
                .Property(e => e.Losenord)
                .IsUnicode(false);

            modelBuilder.Entity<Kund>()
                .Property(e => e.Fornamn)
                .IsUnicode(false);

            modelBuilder.Entity<Kund>()
                .Property(e => e.Efternamn)
                .IsUnicode(false);

            modelBuilder.Entity<Kund>()
                .Property(e => e.PersonNr)
                .IsUnicode(false);

            modelBuilder.Entity<Kund>()
                .Property(e => e.TelefonNr)
                .IsUnicode(false);
        }
    }
}
