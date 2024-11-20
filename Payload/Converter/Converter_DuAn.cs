using bai2api.Entities;
using bai2api.Payload.DTO;

namespace bai2api.Payload.Converter
{
    public class Converter_DuAn
    {

        public DTO_DuAn EntityToDTO(DuAn duAn)
        {
            return new DTO_DuAn
            {
                Id=duAn.Id,
                TenDuAn=duAn.TenDuAn,
                MoTa=duAn.MoTa,
                GhiChu=duAn.GhiChu,
            };
        }

    }
}
