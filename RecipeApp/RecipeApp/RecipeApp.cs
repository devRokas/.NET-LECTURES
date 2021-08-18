using System;
using System.Threading.Tasks;
using Contracts.Enums;
using Domain.Models;
using Domain.Services;

namespace RecipeApp
{
    class RecipeApp
    {
        private readonly IRecipeService _recipeService;

        public RecipeApp(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        public async Task StartAsync()
        {
            int id;
            string name;
            var description = string.Empty;
            Difficulty difficulty;
            int minutes;

            while (true)
            {
                Console.WriteLine("Available commands:");
                Console.WriteLine("1 - Show all recipes");
                Console.WriteLine("2 - Add recipe");
                Console.WriteLine("3 - Edit recipe");
                Console.WriteLine("4 - Delete recipe");
                Console.WriteLine("5 - Delete all recipes");
                Console.WriteLine("6 - Exit");

                var chosenCommand = Console.ReadLine();

                switch (chosenCommand)
                {
                    case "1": 
                        
                        Console.WriteLine("Enter order by TimeToComplete or DateCreated: ");
                        var orderBy = Console.ReadLine();
                        Console.WriteLine("Enter ASC or DESC: ");
                        var orderHow = Console.ReadLine();

                        var recipes = await _recipeService.GetAllAsync(orderBy, orderHow);
                        
                        foreach (var recipe in recipes)
                        {
                            Console.WriteLine(recipe);
                        }
                        
                        break;
                    case "2":
                        Console.WriteLine("Enter recipe Id:");
                        id = Convert.ToInt32(Console.ReadLine());
                        
                        Console.WriteLine("Enter recipe Name:");
                        name = Console.ReadLine();

                        Console.WriteLine("Enter recipe Description: ");
                        description = Console.ReadLine();

                        Console.WriteLine("Enter recipe Difficulty (Easy, Medium, Hard): ");
                        Enum.TryParse(Console.ReadLine(), out difficulty);

                        Console.WriteLine("Enter recipe Time To Complete (min): ");
                        minutes = Convert.ToInt32(Console.ReadLine());

                        await _recipeService.CreateAsync(new Recipe
                        {
                            Id = id,
                            Name = name,
                            Description = description,
                            Difficulty = difficulty,
                            TimeToComplete = TimeSpan.FromMinutes(minutes),
                            DateCreated = DateTime.Now
                        });
                        
                        break;
                    case "3":
                        Console.WriteLine("Enter recipe ID");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter new recipe Name");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter new recipe Description");
                        description = Console.ReadLine();

                        await _recipeService.EditAsync(id, name, description);
                        break;
                    case "4":
                        Console.WriteLine("Enter recipe ID:");
                        id = Convert.ToInt32(Console.ReadLine());

                        await _recipeService.DeleteByIdAsync(id);
                        break;
                    case "5":
                        var deletedRecipesCount = await _recipeService.DeleteAllAsync();
                        Console.WriteLine($"{deletedRecipesCount} recipes were deleted");
                        
                        break;
                    case "6":
                        return;
                }
            }
        }
    }
}