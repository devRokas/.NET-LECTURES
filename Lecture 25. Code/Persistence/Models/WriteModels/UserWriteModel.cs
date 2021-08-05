namespace Persistence.Models.WriteModels
{
    public class UserWriteModel
    {
        public int Id { get; set; }
        
        public string Username { get; set; }

        public string Password { get; set; }

        public string Fullname { get; set; }

        public int Age { get; set; }
    }
}