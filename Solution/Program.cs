using CopyProgram1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    class Program
    {

        static void Main(string[] args)
        {
            Copier copier = new Copier(new FileSystem(), new KeyBoard());
            copier.Copy();

        }
    }
}
