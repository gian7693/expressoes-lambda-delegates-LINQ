using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using Course.Entities;


namespace Course // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string path = "C:/Users/Gian/Documents//CURSO C#/C#COMPLETO - PROGRAMAÇÃO ORIENTADA A OBJETOS/Seção 17 - Expressões lambda, delegates, LINQ/Material/in.txt";

            List<Product> list = new List<Product>();

            try
            {
                using(StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fileds = sr.ReadLine().Split(',');
                        string name = fileds[0];
                        double price = double.Parse(fileds[1], CultureInfo.InvariantCulture);
                        list.Add(new Product { Name = name, Price = price });                
                    }

                    var average = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
                    Console.WriteLine("Average: " + average.ToString("F2", CultureInfo.InvariantCulture));

                    var r2 = list.Where(p => p.Price < average).OrderByDescending(p => p.Name).Select(p => p.Name); 
                    foreach(var p in r2)
                    {
                        Console.WriteLine(p);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error ocurred: " + ex.Message);
            }
        }
    }
}