using AutoMapper;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class BaseService { }
    public class BaseService<TReq, TEntity, TRes> : BaseService, IBaseService<TReq, TEntity, TRes> where TEntity:class
    {
        protected readonly IMapper _mapper;
        public AppDbContext _appDbContext { get; set; }
        public DbSet<TEntity> _dbSet { get; set; }

        public BaseService(AppDbContext appDbContext,IMapper mapper)
        {
            _appDbContext = appDbContext;
            _dbSet = _appDbContext.Set<TEntity>();
            _mapper = mapper;
        }
        public virtual TRes Create(TReq req)
        {
            var source = _mapper.Map<TReq, TEntity>(req);
            var ent=_dbSet.Add(source);
            _appDbContext.SaveChanges();
            var res = _mapper.Map<TEntity, TRes>(source);
            return res;
        }

        public virtual TRes Delete(int id)
        {
            var req = _dbSet.Find(id);
            _dbSet.Remove(req);
            _appDbContext.SaveChanges();
            var res = _mapper.Map<TEntity, TRes>(req);
            return res;
        }

        public virtual TRes Get(int id)
        {
            var req = _dbSet.Find(id);
            var res = _mapper.Map<TEntity, TRes>(req);
            return res;
        }

        public IEnumerable<TRes> Get()
        {
            var req = _mapper.Map<IEnumerable<TEntity>, IEnumerable<TEntity>>(_dbSet);
            var res = _mapper.Map<IEnumerable<TEntity>, IEnumerable<TRes>>(req);
            return res;
        }

        public TRes Update(TReq req)
        {
            var source = _mapper.Map<TReq, TEntity>(req);
            var ent = _dbSet.Update(source);
            _appDbContext.SaveChanges();
            var res = _mapper.Map<TEntity, TRes>(source);
            return res;
        }
    }
}
