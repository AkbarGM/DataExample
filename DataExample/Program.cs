using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExample
{
    class Program
    {
        static void Main(string[] args)
        {

            ProductsRepository products = new ProductsRepository();
            Console.WriteLine("Welcome to our store. Choose a command:\n1-ProductList\n2-Product\n3-Insert Product\n4-Delete Product");
            l1:
            int n = Convert.ToInt32(Console.ReadLine());
            switch(n)
            {
                case 1: products.GetProducts();
                    break;
                case 2:
                    Console.Write("Input ID of Products: ");
                    int Id = Convert.ToInt32(Console.ReadLine());
                    products.GetProductsById(Id);
                    break;
                case 3:
                    Console.Write("Name of Product:");
                    string name = Console.ReadLine();
                    Console.Write("Price of Product:");
                    decimal price = Convert.ToDecimal(Console.ReadLine());
                    products.PutProducts(name, price);
                    break;

            }
            goto l1;
            

            Console.ReadLine();
        }
    }
}
