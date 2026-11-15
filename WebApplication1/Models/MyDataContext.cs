using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class MyDataContext : DbContext
    {
        public MyDataContext()
        {
        }

        public MyDataContext(DbContextOptions<MyDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bookings> Bookings { get; set; }
        public virtual DbSet<Hotels> Hotels { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }
        public virtual DbSet<Reviews> Reviews { get; set; }
        public virtual DbSet<Rooms> Rooms { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(" Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=S:\\כתה יב\\מדעי המחשב\\טליה\\projectTalya\\dataBase\\dataBaseHotel.mdf;Integrated Security=True;Connect Timeout=30");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bookings>(entity =>
            {
                entity.HasKey(e => e.BookingId)
                    .HasName("PK__tmp_ms_x__73951ACD766223E2");

                entity.Property(e => e.BookingId).HasColumnName("BookingID");

                entity.Property(e => e.BookingStatus).HasMaxLength(20);

                entity.Property(e => e.CheckIn).HasMaxLength(50);

                entity.Property(e => e.CheckOut).HasMaxLength(50);

                entity.Property(e => e.CodeHotel).HasColumnName("codeHotel");

                entity.Property(e => e.CreatedAt).HasMaxLength(50);

                entity.Property(e => e.RoomId).HasColumnName("RoomID");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                //entity.HasOne(d => d.Room)
                //    .WithMany(p => p.Bookings)
                //    .HasForeignKey(d => d.RoomId)
                //    .HasConstraintName("FK_Bookings_ToTable_1");

                //entity.HasOne(d => d.User)
                //    .WithMany(p => p.Bookings)
                //    .HasForeignKey(d => d.UserId)
                //    .HasConstraintName("FK_Bookings_ToTable");
            });

            modelBuilder.Entity<Hotels>(entity =>
            {
                entity.HasKey(e => e.IdHotel)
                    .HasName("PK__tmp_ms_x__653BCCC48F8F18F1");

                entity.Property(e => e.Address).HasMaxLength(150);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.HotelName).HasMaxLength(100);

                entity.Property(e => e.ImageUrl).HasMaxLength(500);

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<Payments>(entity =>
            {
                entity.Property(e => e.PaymentsId).HasColumnName("PaymentsID");

                entity.Property(e => e.BookingId).HasColumnName("BookingID");

                entity.Property(e => e.PaymentMethod).HasMaxLength(30);

                entity.Property(e => e.PaymentStatus).HasMaxLength(20);

                //entity.HasOne(d => d.Booking)
                //    .WithMany(p => p.Payments)
                //    .HasForeignKey(d => d.BookingId)
                //    .HasConstraintName("FK_Payments_ToTable");
            });

            modelBuilder.Entity<Reviews>(entity =>
            {
                entity.HasKey(e => e.ReviewId)
                    .HasName("PK__tmp_ms_x__74BC79AEE8A228F3");

                entity.Property(e => e.ReviewId).HasColumnName("ReviewID");

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.HotelId).HasColumnName("HotelID");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                //entity.HasOne(d => d.Hotel)
                //    .WithMany(p => p.Reviews)
                //    .HasForeignKey(d => d.HotelId)
                //    .HasConstraintName("FK_Reviews_ToTable_1");

                //entity.HasOne(d => d.User)
                //    .WithMany(p => p.Reviews)
            //        .HasForeignKey(d => d.UserId)
            //        .HasConstraintName("FK_Reviews_ToTable");
            });

            modelBuilder.Entity<Rooms>(entity =>
            {
                entity.HasKey(e => e.IdRoom)
                    .HasName("PK__tmp_ms_x__B436880FD29ED9A9");

                entity.Property(e => e.HotelId).HasColumnName("HotelID");

                entity.Property(e => e.ImageUrl).HasMaxLength(50);

                entity.Property(e => e.RoomNumber).HasMaxLength(10);

                entity.Property(e => e.RoomType).HasMaxLength(30);

                entity.Property(e => e.Status).HasColumnName("status");

                //entity.HasOne(d => d.Hotel)
                //    .WithMany(p => p.Rooms)
                //    .HasForeignKey(d => d.HotelId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_Rooms_ToTable");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.NumUsers)
                    .HasName("PK__tmp_ms_x__385A0D72DC2B47B4");

                entity.Property(e => e.NumUsers).HasColumnName("numUsers");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.PasswordHash).HasMaxLength(250);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.Role).HasMaxLength(20);

                entity.Property(e => e.Status).HasColumnName("status");
            });

            OnModelCreatingPartial(modelBuilder);
            }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
