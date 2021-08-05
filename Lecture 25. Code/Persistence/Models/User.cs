namespace Persistence.Models
{
    public class User
    {
        public int Id { get; set; }
        
        public string Username { get; set; }

        public string Password { get; set; }

        public string Fullname { get; set; }

        public int Age { get; set; }
        
        // ID | Username | Password | FullName | Age
        // 1  | Destroyer3000 | testas123 | Vardas Vardas | 64575
        // 1  | Destroyer3000 | testas123 | Vardas Vardas | 64575
        // 1  | Destroyer3000 | testas123 | Vardas Vardas | 64575
        // 1  | Destroyer3000 | testas123 | Vardas Vardas | 64575
        // 1  | Destroyer3000 | testas123 | Vardas Vardas | 64575
    }
}