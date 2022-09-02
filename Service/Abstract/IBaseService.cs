using System.Collections.Generic;

namespace Service.Abstract
{
    public interface IBaseService
    {
    }
    public interface IBaseService<TReq, TEntity, TRes> : IBaseService
    {
        public TRes Get(int id);
        public IEnumerable<TRes> Get();
        public TRes Create(TReq req);
        public TRes Update(TReq req);
        public TRes Delete(int id);
    }
}
