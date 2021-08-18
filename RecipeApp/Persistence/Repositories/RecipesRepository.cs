using System.Collections.Generic;
using System.Threading.Tasks;
using Persistence.Filters;
using Persistence.Models.ReadModels;
using Persistence.Models.WriteModels;

namespace Persistence.Repositories
{
    class RecipesRepository : IRecipesRepository
    {
        private const string RecipesTable = "Recipes";
        private const string DescriptionsTable = "Descriptions";
        
        private readonly ISqlClient _sqlClient;
        
        public RecipesRepository(ISqlClient sqlClient)
        {
            _sqlClient = sqlClient;
        }
        
        // RecipeApp.StartAsync() => RecipeService.GetAll() => RecipesRepository.GetAll() => SqlClient.QueryAsync();
        
        public Task<IEnumerable<RecipeReadModel>> GetAll(RecipesFilter filter)
        {
            var sql = @$"SELECT Id, Name, Difficulty, TimeToComplete, DateCreated, Description FROM {RecipesTable} 
                        LEFT JOIN {DescriptionsTable} ON Id = RecipeId
                        ORDER BY {filter.OrderBy} {filter.OrderHow}";
            
            return _sqlClient.QueryAsync<RecipeReadModel>(sql);
        }

        public Task<int> SaveAsync(RecipeWriteModel model)
        {
            var sql = @$"INSERT INTO {RecipesTable} (Id, Name, Difficulty, TimeToComplete, DateCreated) 
                        VALUES (@Id, @Name, @Difficulty, @TimeToComplete, @DateCreated)";
            
            return _sqlClient.ExecuteAsync(sql, new
            {
                model.Id,
                model.Name,
                Difficulty = model.Difficulty.ToString(),
                model.TimeToComplete,
                model.DateCreated
            });
        }

        public Task<int> EditNameAsync(int id, string name)
        {
            var sql = @$"UPDATE {RecipesTable} SET
                         Name = @Name
                         WHERE Id = @Id";
            
            return _sqlClient.ExecuteAsync(sql, new
            {
                Name = name,
                Id = id
            });
        }

        public Task<int> DeleteByIdAsync(int id)
        {
            var sql = @$"DELETE FROM {RecipesTable} WHERE Id = @Id";
            
            return _sqlClient.ExecuteAsync(sql, new
            {
                Id = id
            });
        }

        public Task<int> DeleteAllAsync()
        {
            var sql = @$"DELETE FROM {RecipesTable}";
            
            return _sqlClient.ExecuteAsync(sql);
        }
    }
}