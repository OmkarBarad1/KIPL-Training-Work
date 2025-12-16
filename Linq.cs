using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // var students = new List<Student>
        // {
        //     new Student { Name = "Alice", Grade = "A" },
        //     new Student { Name = "Bob", Grade = "B" },
        //     new Student { Name = "Charlie", Grade = "A" },
        //     new Student { Name = "David", Grade = "C" }
        // };
        
        //Query syntax
        
        // var groupedByGrade = from student in students
        //                      group student by student.Grade into gradeGroup
        //                      select gradeGroup;
        
        //Method Syntax
        // var groupedByGrade = students.GroupBy(s=>s.Grade);

        // foreach (var group in groupedByGrade)
        // {
        //     Console.WriteLine($"Grade: {group.Key}");
        //     foreach (var student in group)
        //     {
        //         Console.WriteLine($"  {student.Name}");
        //     }
        //  }
        
        
        // var numbers = new List<int> { 1, 4, 7, 3, 8, 5 };
        
        //Query Syntax
        
        // var result= from n in numbers where n>3 orderby n select new { Number =n, Square = n*n} ;
        
        
        //Method Syntax
        
        // var result = numbers
        //         .Where(num => num > 3)
        //         .Select(num => new { Number = num, Square = num * num })
        //         .OrderBy(num => num.Number);
        
        
        
        // foreach (var item in result)
        // {
        //     Console.WriteLine($"Number: {item.Number}, Square: {item.Square}");
        // }
        
        
        //Aggregate Functions
        
    //     List<Student> students = new List<Student>()
    //     {
    //         new Student { Id = 1, Name = "Omkar", Marks = 85, Grade = "A" },
    //         new Student { Id = 2, Name = "Amit",  Marks = 70, Grade = "B" },
    //         new Student { Id = 3, Name = "Ravi",  Marks = 60, Grade = "B" },
    //         new Student { Id = 4, Name = "Neha",  Marks = 40, Grade = "C" }
    //     };

    //     int total = (from s in students select s).Count();
        
    //     Console.WriteLine("Total Number of Students are : "+ total);
        
    //     int Passed_Students = (from s in students where(s.Marks>=50) select s). Count();
    //     Console.WriteLine("Total Number of Students Passed are : "+ Passed_Students);
        
    //     int Min_Mark__Amoung_Student = (from s in students select s.Marks). Min();
    //     Console.WriteLine("Minimum Marks Amoung student is : "+ Min_Mark__Amoung_Student);
        
    //     int Max_Mark__Amoung_Student = (from s in students select s.Marks). Max();
    //     Console.WriteLine("Miximum Marks Amoung student is : "+ Max_Mark__Amoung_Student);
    //     var St = from s in students where s.Marks == Max_Mark__Amoung_Student select new{ Name = s.Name,
    //         Mark = s.Marks
    //     };
    //     foreach( var item in St)
    //     {
    //         Console.WriteLine($"Miximum Marks Amoung student is {item.Name} and his marks are : "+ item.Mark);
    //     }
        
    //     int SumOfStudentMarks = (from s in students select s.Marks).Sum();
    //     Console.WriteLine("Sum of Student Marks are : "+ SumOfStudentMarks);
        
    //     double AverageOfStudentMarks = (from s in students select s.Marks).Average();
    //     Console.WriteLine("Average of Student Marks are : "+ AverageOfStudentMarks);
        
    //     var StudentPerGrade = from s in students group s by s.Grade into g select new{
    //         Grade = g.Key,
    //         Count = g.Count()
    //     };
        
    //     foreach (var r in StudentPerGrade)
    // Console.WriteLine($"Grade {r.Grade} : {r.Count}");
        
        
        
        
        
        //Jions
        
        // List<Student> students = new List<Student>()
        // {
        //     new Student { Id = 1, Name = "Omkar", Marks = 85, Grade = "A", DeptId = 1 },
        //     new Student { Id = 2, Name = "Amit",  Marks = 72, Grade = "B", DeptId = 2 },
        //     new Student { Id = 3, Name = "Ravi",  Marks = 65, Grade = "B", DeptId = 1 },
        //     new Student { Id = 4, Name = "Neha",  Marks = 40, Grade = "C", DeptId = 3 },
        //     new Student { Id = 5, Name = "Pooja", Marks = 90, Grade = "A", DeptId = 2 },
        //     new Student { Id = 6, Name = "Kiran", Marks = 30, Grade = "D", DeptId = 0 }
        // };
        
        // List<Department> departments = new List<Department>()
        // {
        //     new Department { DeptId = 1, DeptName = "Computer" },
        //     new Department { DeptId = 2, DeptName = "Mechanical" },
        //     new Department { DeptId = 3, DeptName = "Civil" }
        // };
        
        //inner join
        
         // var result = from s in students join d in departments on s.DeptId equals d.DeptId select new { Name = s.Name, DeptName = d.DeptName };
        
        // foreach(var value in result)
        // {
        //     Console.WriteLine($"the name of the Student is {value.Name} and the Department of student is {value.DeptName}");
        // }
        
        //left join
        
        // var result = from s in students join d in departments on s.DeptId equals d.DeptId into deptGroup from d in deptGroup.DefaultIfEmpty() select new { Name = s.Name, DeptName = d == null ? "No Department" : d.DeptName };
        
        // foreach(var value in result)
        // {
        //     Console.WriteLine($"the name of the Student is {value.Name} and the Department of student is {value.DeptName}");
        // }

        //Right join
        
        List<Student> students = new List<Student>()
        {
            new Student { Id=1, Name="Omkar", DeptId=1 },
            new Student { Id=2, Name="Amit",  DeptId=2 },
            new Student { Id=3, Name="Rohan",  DeptId=0 }
            
        };

        List<Department> departments = new List<Department>()
        {
            new Department { DeptId=1, DeptName="CSE" },
            new Department { DeptId=2, DeptName="ME" },
            new Department { DeptId=3, DeptName="CE" }  
        };
        
        // var result = from d in departments join s in students on d.DeptId equals s.DeptId into SG from s in SG .DefaultIfEmpty() select new {
        //     Name = s == null ? "No student" : s.Name,
        //     Department = d.DeptName
        // };
        
        // foreach (var r in result)
        // {
        //     Console.WriteLine($"STUDENT NAME : {r.Name}, \nDEPARTMENT NAME : {r.Department}");
        // }
        
        //full outer join
        
        var result1 = from d in departments join s in students on d.DeptId equals s.DeptId into SG from s in SG .DefaultIfEmpty() select new {
            Name = s == null ? "No student" : s.Name,
            Department = d.DeptName
        };
        
        var result2 = from s in students join d in departments on s.DeptId equals d.DeptId into SG from d in SG .DefaultIfEmpty() select new {
            Name = s.Name,
            Department = d == null ? "No Department" : d.DeptName
        };
        
        var fullOuterJoin = result1.Union(result2);
        
        foreach (var r in fullOuterJoin)
        {
            Console.WriteLine($"STUDENT NAME : {r.Name}, \nDEPARTMENT NAME : {r.Department}");
        }
    }
    
   
    
    
}

// class Student
// {
//     public string Name { get; set; }
//     public string Grade { get; set; }
// }


//Aggregate functions

// class Student
// {
//     public int Id;
//     public string Name;
//     public int Marks;
//     public string Grade;
// }

//Joins

// class Student
// {
//     public int Id;
//     public string Name;
//     public int DeptId;
//     public int Marks;
//     public string Grade;
// }

// class Department
// {
//     public int DeptId;
//     public string DeptName;
// }

//right join

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int DeptId { get; set; }
}

class Department
{
    public int DeptId { get; set; }
    public string DeptName { get; set; }
}



