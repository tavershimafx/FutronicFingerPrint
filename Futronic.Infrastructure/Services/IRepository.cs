using System.Collections.Generic;
using System.Threading.Tasks;

namespace Futronic.Infrastructure.Services
{
    public interface IRepository<TKey, TModel> where TModel : class
    {
        void Insert(TModel model);

        void Delete(TKey key);

        void Update(TKey key, TModel model);

        Task<TModel> Get(TKey key);

        Task<IEnumerable<TModel>> GetAll();

        Task SaveChangesAsync();

        void SaveChanges();
    }
}
