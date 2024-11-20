using bai2api.DataContext;
using bai2api.Entities;
using bai2api.Payload.Converter;
using bai2api.Payload.DTO;
using bai2api.Payload.Request.DuAn;
using bai2api.Payload.Response;
using bai2api.Service.Interface;

namespace bai2api.Service.Implement
{
    public class Service_DuAn : IService_DuAn
    {
        private readonly AppDbContext dbContext;
        private readonly ResponseObject<DTO_DuAn> responseObject;
        private readonly Converter_DuAn converter_DuAn;
        private readonly ResponseBase responseBase;

        public Service_DuAn(AppDbContext dbContext, ResponseObject<DTO_DuAn> responseObject, Converter_DuAn converter_DuAn, ResponseBase responseBase)
        {
            this.dbContext = dbContext;
            this.responseObject = responseObject;
            this.converter_DuAn = converter_DuAn;
            this.responseBase = responseBase;
        }

        public IQueryable<DTO_DuAn> GetListDuAn(int pageSize, int pageNumber)
        {
            return dbContext.DuAns.Skip((pageNumber - 1) * pageSize).Take(pageSize).Select(x => converter_DuAn.EntityToDTO(x));
        }

        public ResponseObject<DTO_DuAn> SuaDuAn(Request_SuaDuAn request)
        {
            var duAn = dbContext.DuAns.FirstOrDefault(x=>x.Id == request.Id);
            if (duAn == null) {
                return responseObject.ResponseObjectError(StatusCodes.Status404NotFound, "Dự án không tồn tại !", null);
            
            }

            duAn.TenDuAn = request.TenDuAn;
            duAn.GhiChu=request.GhiChu;
            duAn.MoTa=request.MoTa;
            dbContext.DuAns.Update(duAn);
            dbContext.SaveChanges   ();

            return responseObject.ResponseObjectSuccess("Sửa thành công !",converter_DuAn.EntityToDTO(duAn));


        }

        public ResponseObject<DTO_DuAn> ThemDuAn(Request_ThemDuAn request)
        {
            var duAn = new DuAn();
            duAn.TenDuAn = request.TenDuAn;
            duAn.MoTa=request.MoTa;
            duAn.GhiChu=request.GhiChu;
            dbContext.DuAns.Add(duAn);
            dbContext.SaveChanges();
            return responseObject.ResponseObjectSuccess("Thêm thành công", converter_DuAn.EntityToDTO(duAn));

        }

        public ResponseBase XoaDuAn(int DuAnId)
        {
            var duAn = dbContext.DuAns.FirstOrDefault(x => x.Id == DuAnId);
            if (duAn == null)
            {
                return responseBase.ResponseBaseError(StatusCodes.Status404NotFound, "Dự án không tồn tại !");

            }

            dbContext.DuAns.Remove(duAn);
            dbContext.SaveChanges();
            return responseBase.ResponseBaseSuccess("Xóa thành công !");

        }
    }
}
