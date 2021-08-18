using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Services
{
    public interface IRecipeService
    {
        Task<IEnumerable<Recipe>> GetAllAsync(string orderBy, string orderHow);

        Task<int> CreateAsync(Recipe model);

        Task<int> EditAsync(int id, string name, string description);

        Task<int> DeleteByIdAsync(int id);

        Task<int> DeleteAllAsync();
    }
}