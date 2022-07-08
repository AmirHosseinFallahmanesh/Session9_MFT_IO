using System;
using System.IO;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileAddress = @"d:\behsazan\a.txt";

            //WriteToFile(fileAddress);
            //ReadAllText(fileAddress);
            ReadLineText(fileAddress);
        }

        private static void ReadLineText(string fileAddress)
        {
            StreamReader reader = new StreamReader(fileAddress);
            while (!reader.EndOfStream)
            {
                Console.WriteLine(reader.ReadLine());
            }
            reader.Close();
        }

        private static void ReadAllText(string fileAddress)
        {
            StreamReader streamReader = new StreamReader(fileAddress);
            Console.WriteLine(streamReader.ReadToEnd());
            streamReader.Close();
        }

        private static void WriteToFile(string fileAddress)
        {
            StreamWriter writer = new StreamWriter(fileAddress, true);
            //writer.Write("this is first text ....");
            writer.WriteLine("this is line 1 ");
            writer.WriteLine("this is line 2 ");
            writer.WriteLine("this is line 3 ");
            writer.Flush();
            writer.Close();
        }
    }
}
