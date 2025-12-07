using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNI
{
    class Student
    {
        public string Name;
        public int Age;
        public string Major;
    }

    internal class Program
    {
        static Dictionary<string, Student> students = new Dictionary<string, Student>();
        static string filePath = @"C:\UNI.txt";

        static void Main(string[] args)
        {
            LoadFromFile();

            while (true)
            {
                Console.WriteLine("\n=== Menu ===");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Show Students");
                Console.WriteLine("3. Delete Student");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudent();
                        break;

                    case "2":
                        ShowStudents();
                        break;

                    case "3":
                        DeleteStudent();
                        break;

                    case "4":
                        SaveToFile();
                        return;

                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
            }
        }

        static void AddStudent()
        {
            Console.Write("Student ID: ");
            string id = Console.ReadLine();

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Major: ");
            string major = Console.ReadLine();

            Student s = new Student();
            s.Name = name;
            s.Age = age;
            s.Major = major;

            students[id] = s;

            Console.WriteLine("Student saved successfully.");
        }

        static void ShowStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }

            foreach (var item in students)
            {
                Console.WriteLine($"\nStudent ID: {item.Key}");
                Console.WriteLine($"Name: {item.Value.Name}");
                Console.WriteLine($"Age: {item.Value.Age}");
                Console.WriteLine($"Major: {item.Value.Major}");
            }
        }

        static void DeleteStudent()
        {
            Console.Write("Enter Student ID to delete: ");
            string id = Console.ReadLine();

            if (students.ContainsKey(id))
            {
                students.Remove(id);
                Console.WriteLine("Student deleted.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        static void SaveToFile()
        {
            List<string> lines = new List<string>();

            foreach (var item in students)
            {
                lines.Add($"{item.Key},{item.Value.Name},{item.Value.Age},{item.Value.Major}");
            }

            File.WriteAllLines(filePath, lines);

            Console.WriteLine("Data saved to file.");
        }

        static void LoadFromFile()
        {
            if (!File.Exists(filePath))
                return;

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                string id = parts[0];
                string name = parts[1];
                int age = int.Parse(parts[2]);
                string major = parts[3];

                Student s = new Student();
                s.Name = name;
                s.Age = age;
                s.Major = major;

                students[id] = s;
            }
        }
    }
}