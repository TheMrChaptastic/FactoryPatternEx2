using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternEx2
{
    public class MongoDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from Mongo database");
            return new List<Product>();
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to Mongo database");
        }
    }
}
