using System;
using System.Globalization;


namespace Course.Entities
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return Name
                + ", "
                + Email
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
