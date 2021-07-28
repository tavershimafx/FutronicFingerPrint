using Futronic.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Futronic.Infrastructure.Services
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TModel"></typeparam>
    public class Repository<TKey, TModel> : IRepository<TKey, TModel> where TModel : class
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly DbSet<TModel> _dbSet;

        public Repository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// <inheritdoc/>
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
        /// <inheritdoc/>
        /// </summary>
        /// <param name="model"></param>
        public void Delete(TModel model)
        {
            _dbSet.Remove(model);
        }

        /// <summary>
        /// <inheritdoc/>
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
        /// <inheritdoc/>
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public Task<TModel> Get(Expression<Func<TModel, bool>> expression)
        {
            return Task.FromResult(_dbSet.FirstOrDefault(expression));
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<TModel>> GetAll()
        {
            return (await _dbSet.ToListAsync()).AsEnumerable();
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public Task<IEnumerable<TModel>> GetAll(Expression<Func<TModel, bool>> expression)
        {
            return Task.FromResult(_dbSet.Where(expression).AsEnumerable());
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public void Insert(TModel model)
        {
            _dbSet.Add(model);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public (bool, string) SaveChanges()
        {
            try
            {
                _dbContext.SaveChanges();
                return (true, "");
            }
            catch(Exception e)
            {
                return (false, e.Message);
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns></returns>
        public async Task<(bool, string)> SaveChangesAsync()
        {
            try
            {
                await _dbContext.SaveChangesAsync();
                return (true, "");
            }
            catch (Exception e)
            {
                return (false, e.Message);
            }
        }

        /// <summary>
        /// <inheritdoc/>
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
