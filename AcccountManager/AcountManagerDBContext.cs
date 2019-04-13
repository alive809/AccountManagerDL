using AcccountManager.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
namespace AcccountManager
{
    public class AcountManagerDBContext:DbContext
    {
        public AcountManagerDBContext(
            DbContextOptions<AcountManagerDBContext> options):base(options)
        {
        }

        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<Account> Account { get; set; }

        protected override void OnModelCreating( ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountType>()
                .HasKey(r => r.Id);

            modelBuilder.Entity<Account>()
                .HasKey(r => r.Id);

            modelBuilder.Entity<AccountType>()
                .HasIndex(r => r.code)
                .IsUnique(true);

            modelBuilder.Entity<Account>()
                .HasIndex(r => r.Code)
                .IsUnique(true);

            modelBuilder.Entity<Account>()
                .HasOne(r => r.AccountType)
                .WithMany(r => r.Accounts)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
