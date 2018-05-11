namespace CopyProgram2
{
    class Copier
    {
        // remember to reset this flag
        public static bool scannerFlag = true;

        public static void Copy()
        {
            string value;
            while ((value = (scannerFlag ? Scanner.Read() : Keyboard.Read())) != "-1") {
                    Printer.Write(value);
		    }
        }
    }
}
