using CB.ApplicationCore.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using CB.Infrastructure.Data;
using System.Linq;

namespace CB.Infrastructure.Repository
{
    public class EFRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly ContaBancariaContext dbContext;
        public EFRepository(ContaBancariaContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicado) => dbContext.Set<TEntity>().Where(predicado).AsEnumerable();
        
        public IEnumerable<TEntity> GetAll() => dbContext.Set<TEntity>();

        public TEntity GetbyId(int id) => dbContext.Set<TEntity>().Find(id);

        public TEntity Adicionar(TEntity entity)
        {
            dbContext.Set<TEntity>().Add(entity);
            dbContext.SaveChanges();
            return entity;
        }

        public void Atualizar(TEntity entity)
        {
            dbContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
        }

        public void Remover(TEntity entity)
        {
            dbContext.Set<TEntity>().Remove(entity);
            dbContext.SaveChanges();
        }
    }
}
