using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Tutorial_Manager_Final.Models;

public partial class TutorialContext : DbContext
{
    public TutorialContext()
    {
    }

    public TutorialContext(DbContextOptions<TutorialContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Complain> Complains { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<Offer> Offers { get; set; }

    public virtual DbSet<Parent> Parents { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Performance> Performances { get; set; }

    public virtual DbSet<Profile> Profiles { get; set; }

    public virtual DbSet<Rate> Rates { get; set; }

    public virtual DbSet<Schedule> Schedules { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<Tutor> Tutors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-U93620R\\SQLEXPRESS;Initial Catalog=Tutorial;Integrated Security=True;encrypt=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.AddressId).HasName("PK__Address__091C2AFB6AF9B8E6");

            entity.ToTable("Address");

            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.KifleKetema)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.State)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Street).HasMaxLength(70);
        });

        modelBuilder.Entity<Complain>(entity =>
        {
            entity.HasKey(e => e.ComplainId).HasName("PK__Complain__88D54911795F73D2");

            entity.ToTable("Complain");

            entity.Property(e => e.ComplainText)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.Par).WithMany(p => p.Complains)
                .HasForeignKey(d => d.ParId)
                .HasConstraintName("fk_compar");

            entity.HasOne(d => d.Stu).WithMany(p => p.Complains)
                .HasForeignKey(d => d.StuId)
                .HasConstraintName("fk_comstu");

            entity.HasOne(d => d.Tut).WithMany(p => p.Complains)
                .HasForeignKey(d => d.TutId)
                .HasConstraintName("fk_comtut");
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.HasKey(e => e.NotificationId).HasName("PK__Notifica__20CF2E12470709EF");

            entity.ToTable("Notification");

            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.Notification1)
                .HasMaxLength(300)
                .HasColumnName("Notification");

            entity.HasOne(d => d.Par).WithMany(p => p.Notifications)
                .HasForeignKey(d => d.ParId)
                .HasConstraintName("fk_notpar");

            entity.HasOne(d => d.Stu).WithMany(p => p.Notifications)
                .HasForeignKey(d => d.StuId)
                .HasConstraintName("fk_notstu");

            entity.HasOne(d => d.Tut).WithMany(p => p.Notifications)
                .HasForeignKey(d => d.TutId)
                .HasConstraintName("fk_nottut");
        });

        modelBuilder.Entity<Offer>(entity =>
        {
            entity.HasKey(e => e.OfferId).HasName("PK__Offer__8EBCF0912C7D6257");

            entity.ToTable("Offer");

            entity.Property(e => e.Date).HasColumnType("date");

            entity.HasOne(d => d.Par).WithMany(p => p.Offers)
                .HasForeignKey(d => d.ParId)
                .HasConstraintName("fk_offpar");

            entity.HasOne(d => d.Tut).WithMany(p => p.Offers)
                .HasForeignKey(d => d.TutId)
                .HasConstraintName("fk_offtut");
        });

        modelBuilder.Entity<Parent>(entity =>
        {
            entity.HasKey(e => e.ParentId).HasName("PK__Parent__D339516FDA0A73A8");

            entity.ToTable("Parent");

            entity.HasIndex(e => e.Username, "UQ__Parent__536C85E480A01CD0").IsUnique();

            entity.Property(e => e.DateRegistered).HasColumnType("date");
            entity.Property(e => e.EmailAddress).HasMaxLength(255);
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Password).HasMaxLength(20);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.Addr).WithMany(p => p.Parents)
                .HasForeignKey(d => d.AddrId)
                .HasConstraintName("fk_paradd");

            entity.HasOne(d => d.Prof).WithMany(p => p.Parents)
                .HasForeignKey(d => d.ProfId)
                .HasConstraintName("fk_parpro");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("PK__Payment__9B556A38608204C0");

            entity.ToTable("Payment");

            entity.Property(e => e.Anount).HasColumnType("money");

            entity.HasOne(d => d.Par).WithMany(p => p.Payments)
                .HasForeignKey(d => d.ParId)
                .HasConstraintName("fk_paypar");
        });

        modelBuilder.Entity<Performance>(entity =>
        {
            entity.HasKey(e => e.PerformanceId).HasName("PK__Performa__F9606E019BA42F89");

            entity.ToTable("Performance");

            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.Performance1)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Performance");

            entity.HasOne(d => d.Stu).WithMany(p => p.Performances)
                .HasForeignKey(d => d.StuId)
                .HasConstraintName("fk_perstu");

            entity.HasOne(d => d.Tut).WithMany(p => p.Performances)
                .HasForeignKey(d => d.TutId)
                .HasConstraintName("fk_pertut");
        });

        modelBuilder.Entity<Profile>(entity =>
        {
            entity.HasKey(e => e.ProfileId).HasName("PK__Profile__290C88E43067DDA4");

            entity.ToTable("Profile");

            entity.Property(e => e.Bio)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ProfileName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ProfilePicture).HasColumnType("image");
        });

        modelBuilder.Entity<Rate>(entity =>
        {
            entity.HasKey(e => e.RateId).HasName("PK__Rate__58A7CF5C4CE25A52");

            entity.ToTable("Rate");

            entity.Property(e => e.Comment).HasMaxLength(150);

            entity.HasOne(d => d.Par).WithMany(p => p.Rates)
                .HasForeignKey(d => d.ParId)
                .HasConstraintName("fk_ratpar");

            entity.HasOne(d => d.Stu).WithMany(p => p.Rates)
                .HasForeignKey(d => d.StuId)
                .HasConstraintName("fk_ratstu");

            entity.HasOne(d => d.Tut).WithMany(p => p.Rates)
                .HasForeignKey(d => d.TutId)
                .HasConstraintName("fk_rattut");
        });

        modelBuilder.Entity<Schedule>(entity =>
        {
            entity.HasKey(e => e.ScheduleId).HasName("PK__Schedule__9C8A5B4944532E54");

            entity.ToTable("Schedule");

            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.Time).HasColumnType("datetime");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__Student__32C52B992746C9D8");

            entity.ToTable("Student");

            entity.HasIndex(e => e.Username, "UQ__Student__536C85E4F6E7C9B6").IsUnique();

            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Password).HasMaxLength(20);
            entity.Property(e => e.Username)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.Addr).WithMany(p => p.Students)
                .HasForeignKey(d => d.AddrId)
                .HasConstraintName("fk_stuadd");

            entity.HasOne(d => d.Par).WithMany(p => p.Students)
                .HasForeignKey(d => d.ParId)
                .HasConstraintName("fk_stupar");

            entity.HasOne(d => d.Prof).WithMany(p => p.Students)
                .HasForeignKey(d => d.ProfId)
                .HasConstraintName("fk_stupro");

            entity.HasOne(d => d.Tut).WithMany(p => p.Students)
                .HasForeignKey(d => d.TutId)
                .HasConstraintName("fk_stutut");
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasKey(e => e.SubjectId).HasName("PK__Subject__AC1BA3A83069A92F");

            entity.ToTable("Subject");

            entity.Property(e => e.Title)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.Tut).WithMany(p => p.Subjects)
                .HasForeignKey(d => d.TutId)
                .HasConstraintName("fk_subtut");
        });

        modelBuilder.Entity<Tutor>(entity =>
        {
            entity.HasKey(e => e.TutorId).HasName("PK__Tutor__77C70FE2B7A67B5B");

            entity.ToTable("Tutor");

            entity.HasIndex(e => e.Username, "UQ__Tutor__536C85E44F3B2C4B").IsUnique();

            entity.Property(e => e.Cv).HasMaxLength(1);
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Password).HasMaxLength(20);
            entity.Property(e => e.Salary).HasColumnType("money");
            entity.Property(e => e.Username)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.Addr).WithMany(p => p.Tutors)
                .HasForeignKey(d => d.AddrId)
                .HasConstraintName("fk_tutadd");

            entity.HasOne(d => d.Prof).WithMany(p => p.Tutors)
                .HasForeignKey(d => d.ProfId)
                .HasConstraintName("fk_tutpro");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
