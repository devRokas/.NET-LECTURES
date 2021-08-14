

using System.ComponentModel.DataAnnotations.Schema;

namespace Lecture_29
{
    public class Customer
    {
        public int Customer_Id { get; set; }

        public string First_Name { get; set; }

        public string Last_Name { get; set; }

        public string Email { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int Age { get; set; }
        
        public override string ToString()
        {
            return $"{Customer_Id} {First_Name} {Last_Name} {Email} {Age}";
        }
    }
}