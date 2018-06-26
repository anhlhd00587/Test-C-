using System;
using System.Collections.Generic;


namespace Test_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateMenu();
        }

        private static List<Product> list = new List<Product>();

        private static void AddProduct()
        {
            var product = new Product();
            Console.WriteLine("Please enter ProductId: ");
            product.ProductId = Console.ReadLine();
            Console.WriteLine("Please enter ProductName:");
            product.Name = Console.ReadLine();
            Console.WriteLine("Please enter Price:");
            product.Price = Console.ReadLine();
            Console.WriteLine("Add new successfully.");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            list.Add(product);
        }

        private static void Display()
        {
            Console.WriteLine(" ---------Display product records-------------");
            Console.WriteLine("{0, -20} {1, -20} {2,-20}", "ProductId", "ProductName", "Price");
            Console.WriteLine("----------------------------------------------------");
            foreach (var product in list)
            {
                Console.WriteLine("{0, -20} {1, -20} {2,-20}", product.ProductId, product.Name, product.Price);
            }

            Console.ReadLine();
        }

        private static void Delete()
        {
            Console.WriteLine("Please enter ProductID");
            Console.WriteLine("Successfully deleted.");
            string id = Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ProductId.Equals(id))
                {
                    list.RemoveAt(i);
                }
            }
        }

        private static void GenerateMenu()
        {
            while (true)
            {
                Console.WriteLine("-------------PRODUCT------------");
                Console.WriteLine("1.Add product records .");
                Console.WriteLine("2.Display product records .");
                Console.WriteLine("3.Delete product by Id .");
                Console.WriteLine("4.Exit .");
                Console.WriteLine("-------------------------");
                Console.WriteLine("Please enter you choice ?");
                var choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Add product records : ");
                        AddProduct();
                        break;
                    case 2:
                        Console.WriteLine("Display product records :");
                        Display();
                        break;
                    case 3:
                        Console.WriteLine("Delete product by Id :");
                        Delete();
                        break;
                    case 4:
                        Environment.Exit(1);
                        break;
                }
            }
        }
    }
}