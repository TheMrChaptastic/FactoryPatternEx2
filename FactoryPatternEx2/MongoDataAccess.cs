using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternEx2
{
    public class MongoDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("I am reading data from Mongo database");
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to Mongo database");
        }
    }
}
