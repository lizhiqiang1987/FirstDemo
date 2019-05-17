namespace EFDemoFirst
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DarkHorseEntiies : DbContext
    {
        public DarkHorseEntiies()
            : base("name=DarkHorseEntiies")
        {
        }

        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<TblArea> TblArea { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .Property(e => e.DepName)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Employees)
                .WithOptional(e => e.Department)
                .HasForeignKey(e => e.EmpDepId);

            modelBuilder.Entity<Employees>()
                .Property(e => e.EmpName)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.EmpGender)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.EmpEmail)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.EmpAddr)
                .IsUnicode(false);
        }
    }
}
