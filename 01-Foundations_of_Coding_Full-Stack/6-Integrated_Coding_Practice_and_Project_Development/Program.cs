
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    class Student
    {
        public string Name = string.Empty;
        public string ID = string.Empty;
        public int[] Grades = Array.Empty<int>();
        public int SumGrades = 0;
    }

    static void Main(string[] args)
    {
        var students = new List<Student>(); // Create a new list of students

        while (true)
        {
            Console.Write("Enter student name to lookup, 'add' to add, 'list' to show all, or 'quit' to exit: ");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input)) // Check the line is not empty
                continue;
            if (input.Equals("quit", StringComparison.OrdinalIgnoreCase)) // Check to exit
                break;
            if (input.Equals("list", StringComparison.OrdinalIgnoreCase)) // Show all students
            {
                if (students.Count == 0)
                {
                    Console.WriteLine("No students have been added yet.");
                }
                else
                {
                    Console.WriteLine("Students:");
                    foreach (var st in students)
                        Console.WriteLine($"- {st.Name} (ID: {st.ID}) Grades: {(st.Grades != null && st.Grades.Length > 0 ? string.Join(", ", st.Grades) : "None")} Sum: {st.SumGrades}");
                }
                continue; // Show student status
            }
            if (input.Equals("add", StringComparison.OrdinalIgnoreCase)) // Add the student
            {
                AddStudentFlow(students);
                continue;
            }

            // Lookup by name (case-insensitive)
            var found = students.Find(s => s.Name.Equals(input, StringComparison.OrdinalIgnoreCase));
            if (found != null)
            {
                Console.WriteLine($"Student found: {found.Name} (ID: {found.ID}). Sum of grades: {found.SumGrades}");
            }
            else
            {
                Console.Write($"Student '{input}' not found. Add this student? (y/n): ");
                var ans = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(ans) && ans.Trim().Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    AddStudentFlow(students, input);
                }
            }
        }
    }

    static void AddStudentFlow(List<Student> students, string defaultName = null)
    {
        var s = new Student();
        if (!string.IsNullOrWhiteSpace(defaultName))
            s.Name = defaultName;
        else
        {
            Console.Write("Enter student name: ");
            s.Name = Console.ReadLine() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(s.Name))
            {
                Console.WriteLine("Name cannot be empty. Aborting add.");
                return;
            }
        }

        string id;
        do
        {
            Console.Write("Enter student ID (required): ");
            id = Console.ReadLine() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(id))
                Console.WriteLine("ID cannot be empty.");
        } while (string.IsNullOrWhiteSpace(id));
        s.ID = id;

        Console.Write("Enter grades as comma-separated integers (or leave empty): ");
        var gradesLine = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(gradesLine))
        {
            var parts = gradesLine.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            var list = new List<int>();
            foreach (var p in parts)
            {
                if (int.TryParse(p.Trim(), out var g))
                    list.Add(g);
                else
                    Console.WriteLine($"Ignored invalid grade: '{p.Trim()}'");
            }
            s.Grades = list.ToArray();
            s.SumGrades = s.Grades.Length > 0 ? s.Grades.Sum() : 0;
        }
        else
        {
            s.Grades = Array.Empty<int>();
            s.SumGrades = 0;
        }

        students.Add(s);
        Console.WriteLine("Student added.");
    }
}


