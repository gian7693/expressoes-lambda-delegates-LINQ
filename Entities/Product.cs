using System;
using System.Globalization;


namespace Course.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return Name
                + ", "
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
