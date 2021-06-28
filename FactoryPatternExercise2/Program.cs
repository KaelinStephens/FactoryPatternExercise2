using System;
using System.Collections.Generic;

namespace FactoryPatternExercise2
{
    class Program
    {
        static void Main(string[] args)
        {

            // LoadData(): Just print to the console “I am reading data from { whatever type class this is, i.e: list, SQL database, mongo database
            //}” and then return a new list of Product.
            Console.WriteLine("What database do you want to use: a List, SQL, or Mongo?");
            var databaseChoice = Console.ReadLine();
            IDataAccess storedChoice = DataAccessFactory.GetDataAccessType(databaseChoice);
            storedChoice.LoadData();
            storedChoice.SaveData();

        }
    }

}
