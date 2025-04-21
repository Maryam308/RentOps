using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RentOpsObjects.Model;

public partial class RentOpsDBContext : DbContext
{
    public RentOpsDBContext()
    {
    }

    public RentOpsDBContext(DbContextOptions<RentOpsDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AvailabilityStatus> AvailabilityStatuses { get; set; }

    public virtual DbSet<ConditionStatus> ConditionStatuses { get; set; }

    public virtual DbSet<Document> Documents { get; set; }

    public virtual DbSet<Equipment> Equipment { get; set; }

    public virtual DbSet<EquipmentCategory> EquipmentCategories { get; set; }

    public virtual DbSet<ExternalCustomer> ExternalCustomers { get; set; }

    public virtual DbSet<Feedback> Feedbacks { get; set; }

    public virtual DbSet<FileType> FileTypes { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<LogType> LogTypes { get; set; }

    public virtual DbSet<MessageContent> MessageContents { get; set; }

    public virtual DbSet<MessageType> MessageTypes { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<NotificationStatus> NotificationStatuses { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }

    public virtual DbSet<PaymentStatus> PaymentStatuses { get; set; }

    public virtual DbSet<RentalRequest> RentalRequests { get; set; }

    public virtual DbSet<RentalRequestStatus> RentalRequestStatuses { get; set; }

    public virtual DbSet<RentalTransaction> RentalTransactions { get; set; }

    public virtual DbSet<ReturnRecord> ReturnRecords { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Source> Sources { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EquipmentRentalDB;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Document>(entity =>
        {
            entity.HasOne(d => d.FileType).WithMany(p => p.Documents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Document_FileType");

            entity.HasOne(d => d.User).WithMany(p => p.Documents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Document_User");
        });

        modelBuilder.Entity<Equipment>(entity =>
        {
            entity.HasOne(d => d.AvailabilityStatus).WithMany(p => p.Equipment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Equipment_AvailabilityStatus");

            entity.HasOne(d => d.ConditionStatus).WithMany(p => p.Equipment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Equipment_ConditionStatus");

            entity.HasOne(d => d.EquipmentCategory).WithMany(p => p.Equipment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Equipment_EquipmentCategory");

            entity.HasOne(d => d.User).WithMany(p => p.Equipment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Equipment_User");
        });

        modelBuilder.Entity<ExternalCustomer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK_Customer");
        });

        modelBuilder.Entity<Feedback>(entity =>
        {
            entity.HasOne(d => d.Equipment).WithMany(p => p.Feedbacks).HasConstraintName("FK_Feedback_Equipment");

            entity.HasOne(d => d.User).WithMany(p => p.Feedbacks).HasConstraintName("FK_Feedback_User");
        });

        modelBuilder.Entity<FileType>(entity =>
        {
            entity.HasKey(e => e.FileTypeId).HasName("PK_File");
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.HasOne(d => d.LogType).WithMany(p => p.Logs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Log_LogType");

            entity.HasOne(d => d.Source).WithMany(p => p.Logs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Log_Source");

            entity.HasOne(d => d.User).WithMany(p => p.Logs).HasConstraintName("FK_Log_User");
        });

        modelBuilder.Entity<MessageContent>(entity =>
        {
            entity.HasOne(d => d.MessageType).WithMany(p => p.MessageContents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MessageContent_MessageType");
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.HasOne(d => d.MessageContent).WithMany(p => p.Notifications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Notification_MessageContent");

            entity.HasOne(d => d.NotificationStatus).WithMany(p => p.Notifications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Notification_NotificationStatus");

            entity.HasOne(d => d.User).WithMany(p => p.Notifications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Notification_User");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasOne(d => d.PaymentMethod).WithMany(p => p.Payments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Payment_PaymentMethod");

            entity.HasOne(d => d.PaymentStatus).WithMany(p => p.Payments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Payment_PaymentStatus");
        });

        modelBuilder.Entity<RentalRequest>(entity =>
        {
            entity.HasOne(d => d.Equipment).WithMany(p => p.RentalRequests).HasConstraintName("FK_RentalRequest_Equipment");

            entity.HasOne(d => d.RentalRequestStatus).WithMany(p => p.RentalRequests).HasConstraintName("FK_RentalRequest_RentalRequestStatus");

            entity.HasOne(d => d.User).WithMany(p => p.RentalRequests).HasConstraintName("FK_RentalRequest_User");
        });

        modelBuilder.Entity<RentalTransaction>(entity =>
        {
            entity.HasOne(d => d.Customer).WithMany(p => p.RentalTransactions).HasConstraintName("FK_RentalTransaction_ExternalCustomer");

            entity.HasOne(d => d.Employee).WithMany(p => p.RentalTransactionEmployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RentalTransaction_User");

            entity.HasOne(d => d.Equipment).WithMany(p => p.RentalTransactions).HasConstraintName("FK_RentalTransaction_Equipment");

            entity.HasOne(d => d.Payment).WithMany(p => p.RentalTransactions).HasConstraintName("FK_RentalTransaction_Payment");

            entity.HasOne(d => d.RentalRequest).WithMany(p => p.RentalTransactions).HasConstraintName("FK_RentalTransaction_RentalRequest");

            entity.HasOne(d => d.User).WithMany(p => p.RentalTransactionUsers).HasConstraintName("FK_RentalTransaction_UserOptional");
        });

        modelBuilder.Entity<ReturnRecord>(entity =>
        {
            entity.HasOne(d => d.Document).WithMany(p => p.ReturnRecords).HasConstraintName("FK_ReturnRecord_Document");

            entity.HasOne(d => d.RentalTransaction).WithMany(p => p.ReturnRecords)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReturnRecord_RentalTransaction");

            entity.HasOne(d => d.ReturnCondition).WithMany(p => p.ReturnRecords)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReturnRecord_ReturnCondition");
        });

        modelBuilder.Entity<Source>(entity =>
        {
            entity.HasKey(e => e.SourceId).HasName("PK_LogSource");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_Role");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
