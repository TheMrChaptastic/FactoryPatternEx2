using System;
using System.Collections.Generic;

namespace FactoryPatternEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Which Database would you like to use?");
        var uStr = Console.ReadLine();

        IDataAccess database = DataAccessFactory.GetDataAccessType(uStr);
        List<Product> products = database.LoadData();
        database.SaveData();
        }
    }
}
