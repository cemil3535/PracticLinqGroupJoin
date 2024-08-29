using PracticLinqGroupJoin;
using System;
using System.Collections.Generic;
using System.Linq;


// Creating a students collection and assigning values
List<Student> students = new List<Student>()
{
    new Student { StudentId =1, StudentName = "Ali", ClassId = 1 },
    new Student { StudentId =2, StudentName = "Ayse", ClassId = 2 },
    new Student { StudentId =3, StudentName = "Mehmet", ClassId = 1 },
    new Student { StudentId =4, StudentName = "Fatma", ClassId = 3 },
    new Student { StudentId =5, StudentName = "Ahmet", ClassId = 2 },

};


// Creating a classes collection and assigning values
List<Class> classes = new List<Class>()
{
    new Class { ClassId = 1, ClassName = "Matematik"},
    new Class { ClassId = 2, ClassName = "Turkce"},
    new Class { ClassId = 3, ClassName = "Kimya"},
};


// Group join make
var studentAndClass = from c in classes
                      join s in students on c.ClassId equals s.ClassId into studentGroup
                      select new
                      {
                          ClassName = c.ClassName,
                          Students = studentGroup


     
                      };

// Result print
foreach (var student in studentAndClass)
{
    Console.WriteLine($"Sinif: { student.ClassName}");
    foreach(var item in student.Students)
    {
        Console.WriteLine($"Ogrenci: {item.StudentName}");
    }
}
