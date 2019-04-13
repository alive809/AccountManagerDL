using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace AcccountManager.Core
{
    public abstract class DataServiceBase<TEntity, TContext>
        where TEntity: class
        where TContext: DbContext
    {
        public DataServiceBase(IMapper mapper, TContext context)
        {
            Context = context;
            Mapper = mapper;
        }

        protected TContext Context { get; set; }
        protected IMapper Mapper { get; set; }

        public IQueryable<TDto> GetAll<TDto>()
        {
            DbSet<TEntity> table = Context.Set<TEntity>();
            return Mapper.ProjectTo<TDto>(table);
        }

        public IQueryable<TDto> GetAll<TDto>( Expression<Func<TEntity, bool>> filter)
        {
            DbSet<TEntity> table = Context.Set<TEntity>();
            return Mapper.ProjectTo<TDto>(table.Where(filter));
        }
    }
}
