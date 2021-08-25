using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Lecture_37.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Lecture_37
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var startup = new Startup();
            var serviceProvider = startup.ConfigureServices();

            // var jsonPlaceholderClient = serviceProvider.GetService<IJsonPlaceholderClient>();
            //
            // var users = (await jsonPlaceholderClient.GetUsers()).ToList();
            //
            // users.ForEach(Console.WriteLine);
            //
            // var user = await jsonPlaceholderClient.GetUser(6);
            //
            // Console.WriteLine();
            // Console.WriteLine(user);
            //
            // var userTodos = (await jsonPlaceholderClient.GetTodoItems(user.Id)).ToList();
            //
            // Console.WriteLine();
            // userTodos.ForEach(Console.WriteLine);
            //
            // var completedTodos = (await jsonPlaceholderClient.GetTodosByStatus(user.Id, true)).ToList();
            //
            // Console.WriteLine();
            // completedTodos.ForEach(Console.WriteLine);

            var jsonPlaceholderService = serviceProvider.GetService<IJsonPlaceholderService>();

            var user = await jsonPlaceholderService.GetUser(3);
            
            Console.WriteLine(user);

            await jsonPlaceholderService.CreateUser(user);

            var req = new HttpRequestMessage();
        }
    }
}