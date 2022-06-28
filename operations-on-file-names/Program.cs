using System;

namespace operations_on_file_names
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Mumkun olan file uzantilari:  .pdf , .mp3 , .jpg");
                Console.WriteLine("");
                Console.WriteLine("Menyunun hansi dilde olmasini isteyirsiniz?");
                Console.WriteLine("1. English");
                Console.WriteLine("2. Russian");
                Console.WriteLine("3. Azerbaijani");
                Console.WriteLine("");
                string command = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Faylin adini ve uzantisini qeyd edin:");
                Console.WriteLine("");
                string command1 = Console.ReadLine();
                Console.WriteLine("");
                ValidationForFiles classForValudation = new ValidationForFiles(command, command1);
                Console.WriteLine(classForValudation.CheckExtention(command1));
                Console.Write(classForValudation.FindLanguage(command));
                Console.WriteLine(classForValudation.SplitToExtention(command1));
                Console.WriteLine("=====================================================================");
                Console.WriteLine();
            }
        }
    }
}