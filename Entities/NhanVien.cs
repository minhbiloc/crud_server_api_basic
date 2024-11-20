namespace bai2api.Entities
{
    public class NhanVien:EntityBase
    {

        public string HoTen { get; set; }

        public string SoDienThoai { get; set; }

        public string DiaChi { get; set; }

        public string Email { get; set; }

        public Double HeSoLuong { get; set; }

        ICollection<PhanCong>? PhanCongs { get; set; }
    }
}
//I