using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopChoiceHardware.AdressService.Domain.Entities;

namespace TopChoiceHardware.AdressService.AccessData
{
    public class DomicilioContext: DbContext
    {
        public DomicilioContext(){}

        public DomicilioContext(DbContextOptions<DomicilioContext> options): base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Domicilio>(entity =>
            {
                entity.HasKey(e => e.AddressId);
                
                entity.Property(e => e.AddressId)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasMaxLength(100);
                
                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.PostalCode)
                    .IsRequired();


            });
        }

        public virtual DbSet<Domicilio> Domicilio { get; set; }
    }
}
