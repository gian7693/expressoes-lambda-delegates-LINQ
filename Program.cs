using System;
using Course.Services;

namespace Course // Note: actual namespace depends on the project name.
{

    delegate   double BinaryNumericOperation(double n1, double n2);

    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            //double result = CalculationService.Sum(a, b); 

            BinaryNumericOperation op = CalculationService.Sum;
            //BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);


            double result = op(a, b);
            //double result = op.Invoke(a, b);
            Console.WriteLine(result);
        }
    }
}