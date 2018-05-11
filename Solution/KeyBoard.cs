using Solution;
using System;

namespace CopyProgram1
{
    public class KeyBoard : IReader
    {
        public string Read()
        {
            Console.WriteLine("Keyboard - Enter String:");
            return Console.ReadLine();
        }

    }
}
