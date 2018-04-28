using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CB.ApplicationCore.Interfaces.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Adicionar(TEntity entity);
        void Atualizar(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity GetbyId(int id);
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicado);
        void Remover(TEntity entity);
    }
}
