using bai2api.Payload.DTO;
using bai2api.Payload.Request.DuAn;
using bai2api.Payload.Response;

namespace bai2api.Service.Interface
{
    public interface IService_DuAn
    {
        ResponseObject<DTO_DuAn> ThemDuAn(Request_ThemDuAn request);
        ResponseObject<DTO_DuAn> SuaDuAn(Request_SuaDuAn request);
        ResponseBase XoaDuAn(int DuAnId);

        IQueryable<DTO_DuAn> GetListDuAn(int pageSize, int pageNumber);

    }
}
