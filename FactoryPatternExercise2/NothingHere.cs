using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
    public class NothingHere : IDataAccess
    {
        public NothingHere()
        {
            Console.WriteLine("Invalid Entry");
        }
      

        public List<Product> LoadData()
        {
            var newProduct = new List<Product>();
            Console.WriteLine($"Invalid Entry");
            return newProduct;
        }

        public void SaveData()
        {
            Console.WriteLine("Invalid Entry");
        }

    }
}
