using System;
using System.Net.Http;
using System.Threading.Tasks;
using Contracts.FavqsModels;
using Contracts.FavqsModels.Entities;
using Contracts.FavqsModels.RequestModels;
using FavQ.Clients;
using Microsoft.Extensions.DependencyInjection;

namespace FavQ
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var serviceProvider = new Startup().ConfigureServices();
            var favqsClient = serviceProvider.GetService<IFavqsClient>();
            
            var createSessionRequest = new CreateSessionRequest
            {
                User = new User
                {
                    Login = "bit_38",
                    Password = "testas123"
                }
            };

            var response = await favqsClient.CreateSession(createSessionRequest);
            // var quoteResponse = await favqsClient.GetQuote(5458);
            //
            // Console.WriteLine(quoteResponse.Author);
            // Console.WriteLine(quoteResponse.Url);
            // Console.WriteLine(quoteResponse.Body);
            // Console.WriteLine(quoteResponse.FavoritesCount);

            var addQuoteRequest = new AddQuoteRequest
            {
                Quote = new SingleQuote
                {
                    Author = "BIT",
                    Body = "Lecture 40"
                }
            };

            var addQuoteResponse = await favqsClient.AddQuote(response.UserToken, addQuoteRequest);

            Console.WriteLine(addQuoteResponse.Url);
        }
    }
}