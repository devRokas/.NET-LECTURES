using System.Threading.Tasks;
using Persistence.Models.WriteModels;

namespace Persistence.Repositories
{
    class DescriptionsRepository : IDescriptionsRepository
    {
        private const string DescriptionsTable = "Descriptions";
        
        private readonly ISqlClient _sqlClient;

        public DescriptionsRepository(ISqlClient sqlClient)
        {
            _sqlClient = sqlClient;
        }

        public Task<int> SaveAsync(DescriptionWriteModel model)
        {
            var sql = $"INSERT INTO {DescriptionsTable} (RecipeId, Description) VALUES (@RecipeId, @Description)";

            return _sqlClient.ExecuteAsync(sql, model);
        }

        public Task<int> EditDescriptionAsync(int recipeId, string description)
        {
            var sql = @$"UPDATE {DescriptionsTable} SET
                         Description = @Description
                         WHERE RecipeId = @RecipeId";

            return _sqlClient.ExecuteAsync(sql, new
            {
                RecipeId = recipeId,
                Description = description
            });
        }

        public Task<int> DeleteByIdAsync(int id)
        {
            var sql = @$"DELETE FROM {DescriptionsTable} WHERE RecipeId = @RecipeId";
            
            return _sqlClient.ExecuteAsync(sql, new
            {
                RecipeId = id
            });
        }

        public Task<int> DeleteAllAsync()
        {
            var sql = @$"DELETE FROM {DescriptionsTable}";
            
            return _sqlClient.ExecuteAsync(sql);
        }
    }
}