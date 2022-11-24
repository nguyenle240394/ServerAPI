using System;
using System.Collections.Generic;

namespace ServerAPI.Models;

public partial class DmBillOfLadingDetail
{
    public Guid RowId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public Guid BlrowId { get; set; }

    public string CntrNo { get; set; } = null!;

    public string? SealNo { get; set; }

    public string? LocalSizeType { get; set; }

    public string? IsosizeType { get; set; }

    public int NumOfPackage { get; set; }

    public decimal NetWeight { get; set; }

    public decimal GrossWeight { get; set; }

    public decimal Volume { get; set; }

    public bool Inactive { get; set; }

    public string EnterpriseCode { get; set; } = null!;

    public bool? JobStatus { get; set; }

    public DateTime? FinishDate { get; set; }

    public virtual DmBillOfLading Blrow { get; set; } = null!;

    public virtual ICollection<DmPackageList> DmPackageLists { get; } = new List<DmPackageList>();
}
