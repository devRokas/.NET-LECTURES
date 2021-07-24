using System;

namespace Lecture_18
{
    class Program
    {
        static void Main(string[] args)
        {
            var parduotuve = new Shop();
            var user = new User();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("|Sveiki atvyke i parduotuve!|");
            Console.WriteLine("--------------------------------");
            
            while (true)
            {
                Console.Write("Pasirinkite ka norite nuveikti parduotuveje: \n" +
                    "1 - Parodyti, ka galima nusipirkti parduotuveje; \n" +
                    "2 - Nusipirkti prekes; \n" +
                    "3 - Papildyti parduotuve prekemis. \n" +
                    "4 - Iseiti is parduotuves \n");

                Console.WriteLine("Jusu pasirinkimas: ");
                var pasirinkimas = Convert.ToInt32(Console.ReadLine());
                
                switch (pasirinkimas)
                {
                    case 1:
                        Console.WriteLine("Parduotuveje yra: ");
                        parduotuve.List();
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("Parduotuveje yra: ");
                        parduotuve.List();
                        Console.WriteLine();

                        Console.Write("Pasirinkite produkto Id: ");
                        var buyProductId = Convert.ToInt32(Console.ReadLine());
                        
                        Console.Write("Pasirinkite produkto kieki: ");
                        var buyProductQty = Convert.ToInt32(Console.ReadLine());

                        parduotuve.Buy(buyProductId, buyProductQty);
                        break;
                    case 3:
                        Console.WriteLine("Parduotuveje yra: ");
                        parduotuve.List();
                        Console.WriteLine();

                        Console.Write("Pasirinkite produkto Id: ");
                        var addProductId = Convert.ToInt32(Console.ReadLine());
                        
                        Console.Write("Pasirinkite produkto kieki: ");
                        var addProductQty = Convert.ToInt32(Console.ReadLine());

                        parduotuve.Add(addProductId, addProductQty);
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Negalima atlikti tokio veiksmo. Bandykite dar karta!");
                        break;
                }
            }
        }
    }
}
