namespace CopyProgram1
{
    class Copier
    {
        public static void Copy()
        {
            string value;
            while ((value = Keyboard.Read()) != "-1") {
                    Printer.Write(value);
		    }
        }
    }
}
