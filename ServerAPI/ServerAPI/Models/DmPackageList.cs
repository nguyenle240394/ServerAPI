using System;
using System.Collections.Generic;

namespace ServerAPI.Models;

public partial class DmPackageList
{
    public Guid RowId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public Guid BldetailRowId { get; set; }

    public string CntrNo { get; set; } = null!;

    public string? ShipKey { get; set; }

    public string CaseNo { get; set; } = null!;

    public decimal NetWeight { get; set; }

    public decimal GrossWeight { get; set; }

    public decimal Width { get; set; }

    public decimal Length { get; set; }

    public decimal Height { get; set; }

    public decimal Volume { get; set; }

    public string LotOrder { get; set; } = null!;

    public string? IssuedOrder { get; set; }

    public string? SaleInvoiceNo { get; set; }

    public string? Remark { get; set; }

    public string? UsequimentCode { get; set; }

    public string? UsworkerGroupCode { get; set; }

    public string? UsdeliveryEmployeeCode { get; set; }

    public DateTime? UsbeginDate { get; set; }

    public DateTime? UsfinishDate { get; set; }

    public string? UsjobStatus { get; set; }

    public string? Usremark { get; set; }

    public string? WareHouseCode { get; set; }

    public string? ZoneCode { get; set; }

    public int? RowIndex { get; set; }

    public int? BayIndex { get; set; }

    public int? TierIndex { get; set; }

    public string? IwjobStatus { get; set; }

    public string? IwequimentCode { get; set; }

    public string? IwworkerGroupCode { get; set; }

    public string? IwdeliveryEmployeeCode { get; set; }

    public DateTime? IwbeginDate { get; set; }

    public DateTime? IwfinishDate { get; set; }

    public string? Iwremark { get; set; }

    public string? IwtruckNo { get; set; }

    public string? OwjobStatus { get; set; }

    public string? OwequimentCode { get; set; }

    public string? OwworkerGroupCode { get; set; }

    public string? OwdeliveryEmployeeCode { get; set; }

    public DateTime? OwbeginDate { get; set; }

    public DateTime? OwfinishDate { get; set; }

    public string? Owremark { get; set; }

    public string? OwtruckNo { get; set; }

    public string? OwtruckVoy { get; set; }

    public string? OwcheckListNo { get; set; }

    public DateTime? FtfinishDate { get; set; }

    public string? FtcomfirmEmployeeCode { get; set; }

    public string? Ftremark { get; set; }

    public bool Inactive { get; set; }

    public string EnterpriseCode { get; set; } = null!;

    public string? CargoGroupCode { get; set; }

    public string CargoCode { get; set; } = null!;

    public string? PlanWarehouseCode { get; set; }

    public string? PlanZoneCode { get; set; }

    public string? PlanRowRange { get; set; }

    public string? RequestTypeCode { get; set; }

    public string? Barcode { get; set; }

    public string? BarcodeStructure { get; set; }

    public bool IsBarcodePrinted { get; set; }

    public string? Lpncode { get; set; }

    public string? OutwardDeclarationNo { get; set; }

    public DateTime? OutwardDeclarationDate { get; set; }

    public string? OutwardDeclarationStatus { get; set; }

    public string? OutwardDeclarationColor { get; set; }

    public string? OutwardDeclarationType { get; set; }

    public string? FtplaceCode { get; set; }

    public string? PlanDoorCodeList { get; set; }

    public int PackageListStatusCode { get; set; }

    public string? OwdriverEmployeeCode { get; set; }

    public string? IwdriverEmployeeCode { get; set; }

    public string? IwtruckVoy { get; set; }

    public int RowTt { get; set; }

    public string? UsjobStatusBc { get; set; }

    public bool? CaseCheck { get; set; }

    public string? CaseGroup { get; set; }

    public string? Ftstatus { get; set; }

    public string? Ftcode { get; set; }

    public virtual DmBillOfLadingDetail BldetailRow { get; set; } = null!;
}
