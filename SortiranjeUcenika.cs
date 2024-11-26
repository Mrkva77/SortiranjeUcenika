using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {

        List<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John" },
            new Student() { StudentID = 2, StudentName = "Moin" },
            new Student() { StudentID = 3, StudentName = "Bill" },
            new Student() { StudentID = 4, StudentName = "Ram" },
            new Student() { StudentID = 5, StudentName = "Ron" }
        };


        var studentsWithO = studentList.Where(student => student.StudentName.ToLower().Contains("o"));


        foreach (var student in studentsWithO)
        {
            Console.WriteLine($"Student ID: {student.StudentID}, Name: {student.StudentName}");
        }
    }
}

public class Student
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }
}



