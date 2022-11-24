using Microsoft.EntityFrameworkCore;
using ServerAPI.Models;
using ServerAPI.Repository;

namespace ServerAPI.Service
{
    public class BillOfLoadingDetailService : IBillOfLoadingDetailRepository
    {
        private readonly WmsClpDnTestContext _context;
        public BillOfLoadingDetailService(WmsClpDnTestContext context)
        {
            _context = context;
        }

        public IEnumerable<BillOfLoadingInformation> GetListWithDatetimeAsync()
        {
            var dateTimeCheck = DateTime.Now;
            var fromDate = dateTimeCheck.ToString("d");
            var todate = dateTimeCheck.AddDays(1).ToString("d");
            var listBillOfLoading = (from bld in _context.DmBillOfLadingDetails
                                     join bl in _context.DmBillOfLadings on bld.BlrowId equals bl.RowId
                                     join pk in _context.DmPackageLists on bld.RowId equals pk.BldetailRowId
                                     where bld.CreatedDate >= DateTime.Parse(fromDate)
                                     where bld.CreatedDate <= DateTime.Parse(todate)
                                     select new BillOfLoadingInformation()
                                     {
                                         Cntr = bld.CntrNo,
                                         HBLNo = bl.Hblno,
                                         LotOrder = pk.LotOrder,
                                         JobStatus = (bool)bld.JobStatus
                                         /*FinishDate = (DateTime)bld.FinishDate*/
                                     }).ToList();
            return listBillOfLoading;
        }
    }
}
