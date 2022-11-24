using ServerAPI.Models;

namespace ServerAPI.Repository
{
    public interface IBillOfLoadingDetailRepository
    {
        IEnumerable<BillOfLoadingInformation> GetListWithDatetimeAsync();
    }
}
