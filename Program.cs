using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using Course.Entities;
using System.Diagnostics.CodeAnalysis;


namespace Course // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string path = "C:/Users/Gian/Documents//CURSO C#/C#COMPLETO - PROGRAMAÇÃO ORIENTADA A OBJETOS/Seção 17 - Expressões lambda, delegates, LINQ/Material/in2.txt";

            List<Employee> list = new List<Employee>();

            try
            {
                using(StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fileds = sr.ReadLine().Split(',');
                        string name = fileds[0];
                        string email = fileds[1];
                        double salary = double.Parse(fileds[2], CultureInfo.InvariantCulture);
                        list.Add(new Employee { Name = name, Email = email, Salary = salary });                
                    }

                    Console.Write("Enter salary: ");
                    double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    var emails = list.Where(p => p.Salary > value).OrderBy(p => p.Email).Select(p => p.Email);
                   

                    var sum = list.Where((p) => p.Name.ToLower().StartsWith('m')).Sum(p => p.Salary);

                    Console.WriteLine("Email of people whose salary is more than " + value.ToString("F2", CultureInfo.InvariantCulture) + ":");
                    foreach (string email in emails)
                    {
                        Console.WriteLine(email);
                    }

                    Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error ocurred: " + ex.Message);
            }
        }
    }
}