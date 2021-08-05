namespace Persistence.Models.ReadModels
{
    public class UserShortInfoReadModel
    {
        public int Id { get; set; }

        public string Username { get; set; }
        
        // SELECT Id, Username FROM Users
    }
}