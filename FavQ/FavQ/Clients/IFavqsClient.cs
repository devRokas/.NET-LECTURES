using System.Threading.Tasks;
using Contracts.FavqsModels.Entities;
using Contracts.FavqsModels.RequestModels;
using Contracts.FavqsModels.ResponseModels;

namespace FavQ.Clients
{
    public interface IFavqsClient
    {
        Task<CreateSessionResponse> CreateSession(CreateSessionRequest request);

        Task<Quote> GetQuote(int id);
        
        Task<Quote> AddQuote(string userToken, AddQuoteRequest request);
    }
}