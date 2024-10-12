using System;
using Microsoft.EntityFrameworkCore;

namespace VehicleRentalApp.Models
{
    public partial class ReservationsContext : DbContext
    {
        public ReservationsContext()
        {
        }

        public ReservationsContext(DbContextOptions<ReservationsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Reservation> reservationsTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Ensure to update the connection string to match your database settings
            optionsBuilder.UseNpgsql("Host=localhost;Database=YourDatabase;Username=YourUsername;Password=YourPassword");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.HasKey(e => e.reservationid);

                entity.ToTable("reservations");

                entity.Property(e => e.drivername)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.vehiclemodel)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.vehicletype)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.reservationdate)
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.checkoutdate)
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.returndate)
                    .HasColumnType("timestamp without time zone")
                    .IsRequired(false); // Nullable for extensions

                entity.Property(e => e.totalcost)
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.status)
                    .HasMaxLength(20)
                    .HasDefaultValue("Active");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
