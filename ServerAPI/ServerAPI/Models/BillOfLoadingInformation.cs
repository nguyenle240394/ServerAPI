namespace ServerAPI.Models
{
    public class BillOfLoadingInformation
    {
        public string Cntr { get; set; }
        public string HBLNo { get; set; }
        public string LotOrder { get; set; }
        public Boolean JobStatus { get; set; }
        public DateTime FinishDate { get; set; }
    }
}
