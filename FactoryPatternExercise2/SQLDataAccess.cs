using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public SQLDataAccess()
        {

        }
        public List<Product> LoadData()
        {
            Console.WriteLine($"I am reading data from a SQL database");
            var newProduct = new List<Product>();
            return newProduct;
        }

        public  void SaveData()
        {
            Console.WriteLine("I am saving data from a SQL database");
        }
    }
}
