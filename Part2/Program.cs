using System;
using System.Collections.Generic;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileContext fileContext = new FileContext("demo.txt");
            List<Student> students = fileContext.Load();
            while (true)
            {
                menu();
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        {
                            Console.Clear();
                            Console.WriteLine("Enter Name");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter Surname");
                            string surname = Console.ReadLine();
                            Console.WriteLine("Enter Age");
                            int age = Convert.ToInt32(Console.ReadLine());
                            Student student = new Student()
                            {
                                Age = age,
                                Name = name,
                                Surname = surname
                            };
                            students.Add(student);

                        }
                        break;

                    case "2":
                        Console.Clear();
                        for (int i = 0; i < students.Count; i++)
                        {
                            Console.WriteLine("Name "+students[i].Name);
                            Console.WriteLine("Surname "+students[i].Surname);
                            Console.WriteLine("Age "+students[i].Age);
                            Console.WriteLine("**********");
                        }
                        Console.ReadKey();
                        break;
                    case "3":
                        fileContext.Save(students);
                        return;
                     

                    default:
                        Console.WriteLine("Try Again");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private static void menu()
        {
            Console.Clear();
            Console.WriteLine("1)Add Student");
            Console.WriteLine("2)Print Students");
            Console.WriteLine("3)Save and Exit");
        }
    }
}
