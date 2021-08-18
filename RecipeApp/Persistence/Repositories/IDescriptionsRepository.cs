using System.Threading.Tasks;
using Persistence.Models.WriteModels;

namespace Persistence.Repositories
{
    public interface IDescriptionsRepository
    {
        Task<int> SaveAsync(DescriptionWriteModel model);

        Task<int> EditDescriptionAsync(int id, string description);

        Task<int> DeleteByIdAsync(int id);

        Task<int> DeleteAllAsync();
    }
}