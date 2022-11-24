using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ServerAPI.Models;

public partial class WmsClpDnTestContext : DbContext
{
    public WmsClpDnTestContext()
    {
    }

    public WmsClpDnTestContext(DbContextOptions<WmsClpDnTestContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DmBillOfLading> DmBillOfLadings { get; set; }

    public virtual DbSet<DmBillOfLadingDetail> DmBillOfLadingDetails { get; set; }

    public virtual DbSet<DmPackageList> DmPackageLists { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DmBillOfLading>(entity =>
        {
            entity.HasKey(e => new { e.ShipKey, e.Hblno });

            entity.ToTable("DM_BillOfLading");

            entity.HasIndex(e => e.RowId, "UNQ_RowID_DM_BillOfLading").IsUnique();

            entity.Property(e => e.ShipKey).HasMaxLength(20);
            entity.Property(e => e.Hblno)
                .HasMaxLength(40)
                .HasColumnName("HBLNo");
            entity.Property(e => e.BondedWarehouseContractNo)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EnterpriseCode)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.FromPort).HasMaxLength(100);
            entity.Property(e => e.InwardDeclarationDate).HasColumnType("datetime");
            entity.Property(e => e.InwardDeclarationNo)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.InwardDeclarationStatus)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Lcnumber)
                .HasMaxLength(40)
                .HasColumnName("LCNumber");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NoteBill).HasMaxLength(100);
            entity.Property(e => e.OutwardDeclarationDate).HasColumnType("datetime");
            entity.Property(e => e.OutwardDeclarationNo)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.OutwardDeclarationStatus)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Pod)
                .HasMaxLength(6)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(6)
                .HasColumnName("POL");
            entity.Property(e => e.Quantity).HasColumnType("decimal(28, 8)");
            entity.Property(e => e.RowId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("RowID");
            entity.Property(e => e.SaleContractDate).HasColumnType("datetime");
            entity.Property(e => e.SaleContractNo).HasMaxLength(40);
            entity.Property(e => e.UnitCode)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DmBillOfLadingDetail>(entity =>
        {
            entity.HasKey(e => new { e.BlrowId, e.CntrNo });

            entity.ToTable("DM_BillOfLadingDetail");

            entity.HasIndex(e => e.RowId, "UNQ_RowID_DM_BillOfLadingDetail").IsUnique();

            entity.Property(e => e.BlrowId).HasColumnName("BLRowID");
            entity.Property(e => e.CntrNo).HasMaxLength(20);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EnterpriseCode)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.FinishDate).HasColumnType("datetime");
            entity.Property(e => e.GrossWeight).HasColumnType("decimal(28, 8)");
            entity.Property(e => e.IsosizeType)
                .HasMaxLength(10)
                .HasColumnName("ISOSizeType");
            entity.Property(e => e.JobStatus).HasDefaultValueSql("((0))");
            entity.Property(e => e.LocalSizeType).HasMaxLength(10);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NetWeight).HasColumnType("decimal(28, 8)");
            entity.Property(e => e.RowId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("RowID");
            entity.Property(e => e.SealNo).HasMaxLength(20);
            entity.Property(e => e.Volume).HasColumnType("decimal(28, 8)");

            entity.HasOne(d => d.Blrow).WithMany(p => p.DmBillOfLadingDetails)
                .HasPrincipalKey(p => p.RowId)
                .HasForeignKey(d => d.BlrowId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DM_BillOfLadingDetail_ToBillOfLading");
        });

        modelBuilder.Entity<DmPackageList>(entity =>
        {
            entity.HasKey(e => new { e.BldetailRowId, e.CaseNo, e.LotOrder });

            entity.ToTable("DM_PackageList");

            entity.HasIndex(e => e.Barcode, "ID_Barcode_On_DM_PackageList");

            entity.HasIndex(e => e.Lpncode, "ID_LPNCode_On_DM_PackageList");

            entity.Property(e => e.BldetailRowId).HasColumnName("BLDetailRowID");
            entity.Property(e => e.CaseNo).HasMaxLength(40);
            entity.Property(e => e.LotOrder).HasMaxLength(40);
            entity.Property(e => e.Barcode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BarcodeStructure)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CargoCode)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.CargoGroupCode)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.CaseGroup)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.CntrNo).HasMaxLength(20);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EnterpriseCode)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Ftcode)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("FTCode");
            entity.Property(e => e.FtcomfirmEmployeeCode)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FTComfirmEmployeeCode");
            entity.Property(e => e.FtfinishDate)
                .HasColumnType("datetime")
                .HasColumnName("FTFinishDate");
            entity.Property(e => e.FtplaceCode)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FTPlaceCode");
            entity.Property(e => e.Ftremark)
                .HasMaxLength(1021)
                .HasColumnName("FTRemark");
            entity.Property(e => e.Ftstatus)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("FTStatus");
            entity.Property(e => e.GrossWeight).HasColumnType("decimal(28, 8)");
            entity.Property(e => e.Height).HasColumnType("decimal(28, 8)");
            entity.Property(e => e.IssuedOrder).HasMaxLength(40);
            entity.Property(e => e.IwbeginDate)
                .HasColumnType("datetime")
                .HasColumnName("IWBeginDate");
            entity.Property(e => e.IwdeliveryEmployeeCode)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("IWDeliveryEmployeeCode");
            entity.Property(e => e.IwdriverEmployeeCode)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("IWDriverEmployeeCode");
            entity.Property(e => e.IwequimentCode)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("IWEquimentCode");
            entity.Property(e => e.IwfinishDate)
                .HasColumnType("datetime")
                .HasColumnName("IWFinishDate");
            entity.Property(e => e.IwjobStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("IWJobStatus");
            entity.Property(e => e.Iwremark)
                .HasMaxLength(1021)
                .HasColumnName("IWRemark");
            entity.Property(e => e.IwtruckNo)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("IWTruckNo");
            entity.Property(e => e.IwtruckVoy)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("IWTruckVoy");
            entity.Property(e => e.IwworkerGroupCode)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("IWWorkerGroupCode");
            entity.Property(e => e.Length).HasColumnType("decimal(28, 8)");
            entity.Property(e => e.Lpncode)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("LPNCode");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NetWeight).HasColumnType("decimal(28, 8)");
            entity.Property(e => e.OutwardDeclarationColor)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.OutwardDeclarationDate).HasColumnType("datetime");
            entity.Property(e => e.OutwardDeclarationNo)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.OutwardDeclarationStatus)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.OutwardDeclarationType)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.OwbeginDate)
                .HasColumnType("datetime")
                .HasColumnName("OWBeginDate");
            entity.Property(e => e.OwcheckListNo)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("OWCheckListNo");
            entity.Property(e => e.OwdeliveryEmployeeCode)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("OWDeliveryEmployeeCode");
            entity.Property(e => e.OwdriverEmployeeCode)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("OWDriverEmployeeCode");
            entity.Property(e => e.OwequimentCode)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("OWEquimentCode");
            entity.Property(e => e.OwfinishDate)
                .HasColumnType("datetime")
                .HasColumnName("OWFinishDate");
            entity.Property(e => e.OwjobStatus)
                .HasMaxLength(10)
                .HasColumnName("OWJobStatus");
            entity.Property(e => e.Owremark)
                .HasMaxLength(1021)
                .HasColumnName("OWRemark");
            entity.Property(e => e.OwtruckNo)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("OWTruckNo");
            entity.Property(e => e.OwtruckVoy)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("OWTruckVoy");
            entity.Property(e => e.OwworkerGroupCode)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("OWWorkerGroupCode");
            entity.Property(e => e.PlanDoorCodeList).HasMaxLength(255);
            entity.Property(e => e.PlanRowRange).HasMaxLength(255);
            entity.Property(e => e.PlanWarehouseCode)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.PlanZoneCode)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Remark).HasMaxLength(1021);
            entity.Property(e => e.RequestTypeCode)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.RowId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("RowID");
            entity.Property(e => e.RowTt)
                .ValueGeneratedOnAdd()
                .HasColumnName("RowTT");
            entity.Property(e => e.SaleInvoiceNo).HasMaxLength(40);
            entity.Property(e => e.ShipKey).HasMaxLength(20);
            entity.Property(e => e.UsbeginDate)
                .HasColumnType("datetime")
                .HasColumnName("USBeginDate");
            entity.Property(e => e.UsdeliveryEmployeeCode)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("USDeliveryEmployeeCode");
            entity.Property(e => e.UsequimentCode)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("USEquimentCode");
            entity.Property(e => e.UsfinishDate)
                .HasColumnType("datetime")
                .HasColumnName("USFinishDate");
            entity.Property(e => e.UsjobStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("USJobStatus");
            entity.Property(e => e.UsjobStatusBc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("USJobStatusBC");
            entity.Property(e => e.Usremark)
                .HasMaxLength(1021)
                .HasColumnName("USRemark");
            entity.Property(e => e.UsworkerGroupCode)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("USWorkerGroupCode");
            entity.Property(e => e.Volume).HasColumnType("decimal(28, 8)");
            entity.Property(e => e.WareHouseCode)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Width).HasColumnType("decimal(28, 8)");
            entity.Property(e => e.ZoneCode)
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.HasOne(d => d.BldetailRow).WithMany(p => p.DmPackageLists)
                .HasPrincipalKey(p => p.RowId)
                .HasForeignKey(d => d.BldetailRowId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DM_PackageList_To_DM_BillOfLadingDetail");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
