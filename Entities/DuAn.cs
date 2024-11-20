namespace bai2api.Entities
{
    public class DuAn:EntityBase
    {
        
        public string TenDuAn { get; set; }

        public string MoTa { get; set; }

        public string GhiChu { get; set; }

        ICollection<PhanCong>? PhanCongs { get; set; }
       
    }
}
