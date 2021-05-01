using System.Collections.Generic;
using System.Threading.Tasks;

namespace XamaCounter.Data.Interfaces
{
    public interface IGenericDatabase<TModel>
    {
        Task<List<TModel>> GetAsync();

        Task<TModel> GetAsync(int id);

        Task<int> SaveAsync(TModel model);

        Task<int> DeleteAsync(TModel model);
    }
}