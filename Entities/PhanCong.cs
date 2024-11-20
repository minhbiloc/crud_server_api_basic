using System.ComponentModel.DataAnnotations;

namespace bai2api.Entities
{
    public class PhanCong:EntityBase
    {

        public int NhanVienId { get; set; }

        public int DuAnId { get; set; }

        public double SoGioLam { get; set; }

        public NhanVien? NhanVien { get; set; }

        public DuAn? DuAn { get; set; }
    }
}
