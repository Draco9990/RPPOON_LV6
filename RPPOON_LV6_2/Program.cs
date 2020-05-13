using System;

namespace RPPOON_LV6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadatak 2: \n");
            Box box = new Box();
            box.AddProduct(new Product("Kul proizvod 1", 15));
            box.AddProduct(new Product("Kul proizvod 2", 5));
            box.AddProduct(new Product("Kul proizvod 3", 315));
            Iterator iterator = (Iterator)box.GetIterator();
            for (Product currProduct = iterator.First(); !iterator.IsDone; currProduct = iterator.Next())
            {
                Console.WriteLine(currProduct.ToString());
            }
            Console.WriteLine("\n-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-\n");
        }
    }
}
