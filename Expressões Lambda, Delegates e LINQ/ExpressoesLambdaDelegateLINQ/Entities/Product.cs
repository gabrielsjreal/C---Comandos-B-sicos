using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExpressoesLambdaDelegateLINQ.Comparison
{
    class Product     {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }


        // Esse método é usado com a interface : IComparable<Product>,  para usar esse método é só add a interface
        // Esse método é feito de forma manual, é definido de forma manual cada atributo para a ordenação

        // public int CompareTo(Product other)
        //{
        //  return Name.ToUpper().CompareTo(other.Name.ToUpper());
        //}
    }
}
