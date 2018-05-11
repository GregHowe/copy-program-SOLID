using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Solution
{
    public class FileSystem : IWriter
    {
        public void Save(string value)
        {
            if (!Directory.Exists(@"C:\folder"))
            {
                Directory.CreateDirectory(@"C:\folder");
            }

            File.WriteAllText(@"C:\folder\file.txt", value);
        }
    }
}
