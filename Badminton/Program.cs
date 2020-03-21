using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            File.Create("C:\\project\\new.txt");
            File.WriteAllText("C:\\project\\new.txt", "текст");
            File.AppendAllText("C:\\project\\new.txt", "текст метода AppendAllText ()");
            File.Delete("C:\\project\\new.txt");
            FileStream file1 = new FileStream("C:\\project\\new.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(file1);
            writer.WriteLine("текст");
            writer.Close();
            FileStream file2 = new FileStream("C:\\project\\new.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file2);
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();

            Console.ReadKey();

        }
    }
}