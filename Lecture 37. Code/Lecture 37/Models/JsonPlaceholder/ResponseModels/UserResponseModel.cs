namespace Lecture_37.Models.JsonPlaceholder.ResponseModels
{
    public class UserResponseModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Username { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} {Username}";
        }
    }
}