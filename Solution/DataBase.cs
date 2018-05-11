using Solution;
using System;

namespace CopyProgram1
{
    public class DataBase : IWriter
    {
        public void Save(string value)
        {
            Console.WriteLine(" *Database: " + value);
        }
    }
}
