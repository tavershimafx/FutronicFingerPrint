using Futronic.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futronic.Infrastructure.Services
{
    public class Repository<TKey, TModel> : IRepository<TKey, TModel> where TModel : class
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly DbSet<TModel> _dbSet;

        public Repository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        public void Delete(TKey key)
        {
            TModel model = _dbSet.Find(key);
            if (model != null)
            {
                _dbSet.Remove(model);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        public void Delete(TModel model)
        {
            _dbSet.Remove(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task<TModel> Get(TKey key)
        {
            TModel model = await _dbSet.FindAsync(key);
            if (model != null)
            {
                return model;
            }

            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<TModel>> GetAll()
        {
            return (await _dbSet.ToListAsync()).AsEnumerable();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public void Insert(TModel model)
        {
            _dbSet.Add(model);
        }

        /// <summary>
        /// Saves all pending changes in the tracking collection
        /// </summary>
        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        /// <summary>
        /// Saves all pending changes in the tracking collection in an asynchronous operation
        /// </summary>
        /// <returns></returns>
        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public void Update(TKey key, TModel model)
        {
            TModel nmodel = _dbSet.Find(key);
            if (nmodel != null)
            {
                _dbSet.AddOrUpdate(model);
            }
        }
    }
}
