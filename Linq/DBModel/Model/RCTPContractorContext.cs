using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DBModel.Model
{
    public partial class RCTPContractorContext : DbContext
    {
        public RCTPContractorContext()
        {
        }

        public RCTPContractorContext(DbContextOptions<RCTPContractorContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdjustScheduleDetail> AdjustScheduleDetails { get; set; }
        public virtual DbSet<AdjustScheduleMaster> AdjustScheduleMasters { get; set; }
        public virtual DbSet<Calendar> Calendars { get; set; }
        public virtual DbSet<ContractJobTitle> ContractJobTitles { get; set; }
        public virtual DbSet<ContractOrgn> ContractOrgns { get; set; }
        public virtual DbSet<ContractPersonnel> ContractPersonnel { get; set; }
        public virtual DbSet<ContractorShiftGroup> ContractorShiftGroups { get; set; }
        public virtual DbSet<MaintenanceContract> MaintenanceContracts { get; set; }
        public virtual DbSet<ManagerApproval> ManagerApprovals { get; set; }
        public virtual DbSet<ManagerApprovalInbox> ManagerApprovalInboxes { get; set; }
        public virtual DbSet<MenuGroup> MenuGroups { get; set; }
        public virtual DbSet<MenuItem> MenuItems { get; set; }
        public virtual DbSet<ScheduleAbnormal> ScheduleAbnormals { get; set; }
        public virtual DbSet<ScheduleDetail> ScheduleDetails { get; set; }
        public virtual DbSet<ScheduleMaster> ScheduleMasters { get; set; }
        public virtual DbSet<Shift> Shifts { get; set; }
        public virtual DbSet<SignOffJobTitle> SignOffJobTitles { get; set; }
        public virtual DbSet<SignOffOrgn> SignOffOrgns { get; set; }
        public virtual DbSet<SignOffPersonnel> SignOffPersonnel { get; set; }
        public virtual DbSet<SignOffPersonnelJobTitle> SignOffPersonnelJobTitles { get; set; }
        public virtual DbSet<SignOffPersonnelOrgn> SignOffPersonnelOrgns { get; set; }
        public virtual DbSet<SignOffPersonnelOrgnJobTitle> SignOffPersonnelOrgnJobTitles { get; set; }
        public virtual DbSet<TempSignOffPersonnel> TempSignOffPersonnel { get; set; }
        public virtual DbSet<Uv刷卡即時資訊> Uv刷卡即時資訊s { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RCTPContractor;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Chinese_Taiwan_Stroke_CI_AS");

            modelBuilder.Entity<AdjustScheduleDetail>(entity =>
            {
                entity.ToTable("AdjustScheduleDetail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdjustReason).HasMaxLength(100);

                entity.Property(e => e.AdjustType).HasMaxLength(10);

                entity.Property(e => e.DelegateUserId).HasColumnName("DelegateUserID");

                entity.Property(e => e.Guid).HasMaxLength(500);

                entity.Property(e => e.NewDate).HasColumnType("datetime");

                entity.Property(e => e.OldDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AdjustScheduleMaster>(entity =>
            {
                entity.ToTable("AdjustScheduleMaster");

                entity.HasIndex(e => new { e.ScheduleId, e.Version }, "AK1_AdjustScheduleMaster")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<Calendar>(entity =>
            {
                entity.HasKey(e => e.ThisDate)
                    .HasName("PK_CALENDAR");

                entity.ToTable("Calendar");

                entity.Property(e => e.Dw).HasColumnName("DW");

                entity.Property(e => e.IsHoliday)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Remark).HasMaxLength(50);
            });

            modelBuilder.Entity<ContractJobTitle>(entity =>
            {
                entity.ToTable("ContractJobTitle");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.JobTitle).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(100);
            });

            modelBuilder.Entity<ContractOrgn>(entity =>
            {
                entity.ToTable("ContractOrgn");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<ContractPersonnel>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IdentityNum).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PunchCardNo).HasMaxLength(20);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ContractorShiftGroup>(entity =>
            {
                entity.HasKey(e => new { e.ContractSysId, e.ShiftId })
                    .HasName("PK_CONTRACTORSHIFTGROUP");

                entity.ToTable("ContractorShiftGroup");
            });

            modelBuilder.Entity<MaintenanceContract>(entity =>
            {
                entity.ToTable("MaintenanceContract");

                entity.Property(e => e.BeginDate).HasColumnType("datetime");

                entity.Property(e => e.ContractDescription).HasMaxLength(100);

                entity.Property(e => e.ContractIdExt).HasMaxLength(50);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(100);
            });

            modelBuilder.Entity<ManagerApproval>(entity =>
            {
                entity.ToTable("ManagerApproval");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.SignOpinion).HasMaxLength(1000);

                entity.Property(e => e.SignTime).HasColumnType("datetime");

                entity.Property(e => e.Status).IsRequired();

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_ManagerApproval_REF_ManagerApproval");
            });

            modelBuilder.Entity<ManagerApprovalInbox>(entity =>
            {
                entity.ToTable("ManagerApprovalInbox");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsApproval)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.HasOne(d => d.ManagerApproval)
                    .WithMany(p => p.ManagerApprovalInboxes)
                    .HasForeignKey(d => d.ManagerApprovalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ManagerApprovalInbox_REF_ManagerApproval");
            });

            modelBuilder.Entity<MenuGroup>(entity =>
            {
                entity.ToTable("MenuGroup");
            });

            modelBuilder.Entity<MenuItem>(entity =>
            {
                entity.ToTable("MenuItem");

                entity.HasOne(d => d.MenuGroup)
                    .WithMany(p => p.MenuItems)
                    .HasForeignKey(d => d.MenuGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ScheduleAbnormal>(entity =>
            {
                entity.ToTable("ScheduleAbnormal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AbnormalReason).HasMaxLength(100);

                entity.Property(e => e.CompareDescription).HasMaxLength(100);

                entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");
            });

            modelBuilder.Entity<ScheduleDetail>(entity =>
            {
                entity.ToTable("ScheduleDetail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ExcelJobTitle).HasMaxLength(50);

                entity.Property(e => e.ImportTime).HasColumnType("datetime");

                entity.Property(e => e.IsEdit)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ScheduleDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ScheduleMaster>(entity =>
            {
                entity.ToTable("ScheduleMaster");

                entity.HasComment("參考Files內的班表說明");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ScheduleMonth).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Shift>(entity =>
            {
                entity.ToTable("Shift");

                entity.Property(e => e.CrossDay)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Remark).HasMaxLength(50);

                entity.Property(e => e.ShiftName)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<SignOffJobTitle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SignOffJobTitle");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.JobTitle).HasMaxLength(50);

                entity.Property(e => e.NeedSignOff)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<SignOffOrgn>(entity =>
            {
                entity.ToTable("SignOffOrgn");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bpmlevel).HasColumnName("BPMLevel");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<SignOffPersonnel>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .HasColumnName("EMail");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoginAccount).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.PasswordUpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Salt).HasMaxLength(150);
            });

            modelBuilder.Entity<SignOffPersonnelJobTitle>(entity =>
            {
                entity.ToTable("SignOffPersonnelJobTitle");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<SignOffPersonnelOrgn>(entity =>
            {
                entity.ToTable("SignOffPersonnelOrgn");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<SignOffPersonnelOrgnJobTitle>(entity =>
            {
                entity.ToTable("SignOffPersonnelOrgnJobTitle");

                entity.HasIndex(e => new { e.PersonnelId, e.OrgnId, e.JobTitleId }, "AK1_SignOffPersonnelOrgnJobTitle")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<TempSignOffPersonnel>(entity =>
            {
                entity.ToTable("temp_SignOffPersonnel");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .HasColumnName("EMail");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoginAccount).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.Salt).HasMaxLength(150);
            });

            modelBuilder.Entity<Uv刷卡即時資訊>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("uv_刷卡即時資訊");

                entity.Property(e => e.ContractId).ValueGeneratedOnAdd();

                entity.Property(e => e.契約名稱).HasMaxLength(50);

                entity.Property(e => e.時段).HasMaxLength(4000);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
