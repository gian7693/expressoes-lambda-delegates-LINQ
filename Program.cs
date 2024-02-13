using System;
using System.Collections.Generic;
using Course.Entities;
using System.Linq;

namespace Course // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.00));
            list.Add(new Product("HD Case", 80.90));

            //Func<Product, string> func = p => p.Name.ToUpper();

            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();
            foreach (var p in result)
            {
                Console.WriteLine(p);
            }
        }

        //static string NameUpper(Product p)
        //{
        //    return p.Name.ToUpper();
        //}
    }
}