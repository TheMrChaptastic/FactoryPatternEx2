using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternEx2
{
    public class ListDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("I am reading data from List");
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to List");
        }
    }
}
