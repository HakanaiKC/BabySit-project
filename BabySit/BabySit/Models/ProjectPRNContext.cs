using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BabySit.Models
{
    public partial class ProjectPRNContext : DbContext
    {
        public ProjectPRNContext()
        {
        }

        public ProjectPRNContext(DbContextOptions<ProjectPRNContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<ContractShiftWork> ContractShiftWorks { get; set; }
        public virtual DbSet<FeedBack> FeedBacks { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Shift> Shifts { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserSkill> UserSkills { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server =(local); database = ProjectPRN;uid=sa;pwd=123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Contract>(entity =>
            {
                entity.ToTable("Contract");

                entity.Property(e => e.ContractId).HasColumnName("ContractID");

                entity.Property(e => e.BabySitterId).HasColumnName("BabySitterID");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.BabySitter)
                    .WithMany(p => p.ContractBabySitters)
                    .HasForeignKey(d => d.BabySitterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contract_User1");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.ContractParents)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contract_User");
            });

            modelBuilder.Entity<ContractShiftWork>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ContractShiftWork");

                entity.Property(e => e.BabySitterId).HasColumnName("BabySitterID");

                entity.Property(e => e.ContractId).HasColumnName("ContractID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.HasOne(d => d.BabySitter)
                    .WithMany()
                    .HasForeignKey(d => d.BabySitterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractShiftWork_User");

                entity.HasOne(d => d.Contract)
                    .WithMany()
                    .HasForeignKey(d => d.ContractId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractShiftWork_Contract");
            });

            modelBuilder.Entity<FeedBack>(entity =>
            {
                entity.ToTable("FeedBack");

                entity.Property(e => e.FeedBackId).HasColumnName("FeedBackID");

                entity.Property(e => e.BabySitterId).HasColumnName("BabySitterID");

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.DateComment).HasColumnType("date");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.HasOne(d => d.BabySitter)
                    .WithMany(p => p.FeedBackBabySitters)
                    .HasForeignKey(d => d.BabySitterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeedBack_User");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.FeedBackParents)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeedBack_User1");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasKey(e => e.ProvinceId);

                entity.ToTable("Location");

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

                entity.Property(e => e.ProvinceName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Shift>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Shift");

                entity.Property(e => e.BabySitterId).HasColumnName("BabySitterID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.HasOne(d => d.BabySitter)
                    .WithMany()
                    .HasForeignKey(d => d.BabySitterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Shift_User");
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.ToTable("Skill");

                entity.Property(e => e.SkillId).HasColumnName("SkillID");

                entity.Property(e => e.SkillName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Avatar)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Bank).HasMaxLength(100);

                entity.Property(e => e.BirthOfDate).HasColumnType("date");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(60);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

                entity.Property(e => e.RegisterDate).HasColumnType("date");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK_User_Location");
            });

            modelBuilder.Entity<UserSkill>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.SkillId).HasColumnName("SkillID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Skill)
                    .WithMany()
                    .HasForeignKey(d => d.SkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserSkills_Skill");

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserSkills_User");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
