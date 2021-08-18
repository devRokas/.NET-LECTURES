using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace RecipeApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var startup = new Startup();

            var recipeApp = startup.ConfigureServices().GetService<RecipeApp>();

            await recipeApp.StartAsync();
        }
    }
}