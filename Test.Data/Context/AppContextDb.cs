namespace Test.Data.Context
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public class AppContextDb : DbContext
    {
        public AppContextDb()
            : base("name=AppContextDb")
        {
        }

        public DbSet<Contato> Contato { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contato>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Contato>()
                .Property(e => e.TelefoneResidencial)
                .IsUnicode(false);

            modelBuilder.Entity<Contato>()
                .Property(e => e.TelefoneCelular)
                .IsUnicode(false);
        }
    }
}
