using System.Collections.Generic;
using System.Threading.Tasks;
using Persistence.Filters;
using Persistence.Models.ReadModels;
using Persistence.Models.WriteModels;

namespace Persistence.Repositories
{
    public interface IRecipesRepository
    {
        Task<IEnumerable<RecipeReadModel>> GetAll(RecipesFilter filter);

        Task<int> SaveAsync(RecipeWriteModel model);

        Task<int> EditNameAsync(int id, string name);

        Task<int> DeleteByIdAsync(int id);

        Task<int> DeleteAllAsync();
    }
}