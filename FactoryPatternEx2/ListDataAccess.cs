using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternEx2
{
    public class ListDataAccess : IDataAccess
    {
        public static List<Product> products = new List<Product>() { new Product() { Name = "Skateboard", Price = 20.00}, new Product() { Name = "Xbox", Price = 400.00 } };
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from List");
            return products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to List");
        }
    }
}
