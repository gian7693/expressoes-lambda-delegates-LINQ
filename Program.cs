using System;
using Course.Services;

namespace Course // Note: actual namespace depends on the project name.
{

    delegate void BinaryNumericOperation(double n1, double n2);

    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            // Lógica do input system na unity

            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            op.Invoke(a, b);
        }
    }
}