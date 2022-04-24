using System;
using TaskHomework.Models;


namespace TaskHomework
{ 
    class Program
    {
        

        static void Main(string[] args)
            {
            Products product1 = new Products("Corek Nur", 1, Enums.ProductType.bakery);
            Console.WriteLine(product1);

            Products product2 = new Products("Xani Baligi", 2, Enums.ProductType.fish);
            Console.WriteLine(product2);

            Products product3 = new Products("Fanta", 3, Enums.ProductType.drink);
            Console.WriteLine(product3);

            Products product4 = new Products("Mercan", 4, Enums.ProductType.meat);
            Console.WriteLine(product4);







        }
    }

}

