using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternEx2
{
    public static class DataAccessFactory
    {
        public static IDataAccess GetDataAccessType(string databaseType)
        {
            switch (databaseType)
            {
                case "list":
                case "List":
                case "LIST":
                    return new ListDataAccess();
                case "sql":
                case "Sql":
                case "SQL":
                case "mysql":
                case "Mysql":
                case "MySql":
                case "MySQL":
                    return new SQLDataAccess();
                case "mongo":
                case "Mongo":
                case "MONGO":
                    return new MongoDataAccess();
                default:
                    return new SQLDataAccess();
            }
        }
    }
}
