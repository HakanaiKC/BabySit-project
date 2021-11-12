﻿using System;
using System.IO;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

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

        SqlConnection connection;
        // Khai báo đối tượng thực thi các truy vấn
        SqlCommand command;
        string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            return config["ConnectionStrings:ProjectPRNDB"];
        }

        public virtual DbSet<Favorite> Favorites { get; set; }
        public virtual DbSet<FeedBack> FeedBacks { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Shift> Shifts { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserSkill> UserSkills { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server =(local); database = ProjectPRN;uid=sa;pwd=123456;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Favorite>(entity =>
            {
                entity.HasOne(d => d.Babysitter)
                    .WithMany(p => p.FavoriteBabysitters)
                    .HasForeignKey(d => d.BabysitterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Favorites_User4");

                entity.HasOne(d => d.Parents)
                    .WithMany(p => p.FavoriteParents)
                    .HasForeignKey(d => d.ParentsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Favorites_User3");
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

            modelBuilder.Entity<Message>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Message");

                entity.Property(e => e.Message1)
                    .HasMaxLength(1000)
                    .HasColumnName("Message");

                entity.Property(e => e.ReceiverId).HasColumnName("ReceiverID");

                entity.Property(e => e.SenderId).HasColumnName("SenderID");

                entity.HasOne(d => d.Sender)
                    .WithMany()
                    .HasForeignKey(d => d.SenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Message_User");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("Payment");

                entity.Property(e => e.PaymentId).HasColumnName("paymentID");

                entity.Property(e => e.DateOfPayment).HasColumnType("date");

                entity.Property(e => e.Money).HasColumnType("money");

                entity.Property(e => e.Phone).HasMaxLength(11);

                entity.Property(e => e.TradingCode).HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Payment_User");
            });

            modelBuilder.Entity<Shift>(entity =>
            {
                entity.HasKey(e => new { e.BabySitterId, e.Date });

                entity.ToTable("Shift");

                entity.Property(e => e.BabySitterId).HasColumnName("BabySitterID");

                entity.HasOne(d => d.BabySitter)
                    .WithMany(p => p.Shifts)
                    .HasForeignKey(d => d.BabySitterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Shift_User1");
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


        public int RemoveUserSkills(int userId)
        {
            int result = 0;
            connection = new SqlConnection(GetConnectionString());
            string sql = " delete  from UserSkills where UserID = @userid";
            command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@userid", userId);
            try
            {
                connection.Open();
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return result;

        }
        public int AddUserSkills(int userId, string skillId)
        {
            int result = 0;
            connection = new SqlConnection(GetConnectionString());
            string sql = "  insert into UserSkills (UserID, SkillID) values (@userid,@skillid)";
            command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@userid", userId);
            command.Parameters.AddWithValue("@skillid", skillId);
            try
            {
                connection.Open();
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return result;
        }

        public int UpdateShift(int id, int day, string morning, string afternoon, string night)
        {
            int result = 0;
            connection = new SqlConnection(GetConnectionString());
            string sql = "   update Shift set Morning = @morning, Afternoon = @afternoon,Night = @night where BabySitterID = @userid and Date = @date";
            command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@userid", id);
            command.Parameters.AddWithValue("@date", day);
            command.Parameters.AddWithValue("@morning", morning);
            command.Parameters.AddWithValue("@afternoon", afternoon);
            command.Parameters.AddWithValue("@night", night);
            try
            {
                connection.Open();
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return result;
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
