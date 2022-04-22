using System;  
using System.Collections;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;  
  
namespace ConsoleApp1  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            List<Student> Objstudent = new List<Student>(){  
        new Student() { Name = "Mohamed", Gender = "Male", Subjects = new List<string> { "Mathematics", "Physics" } },  
        new Student() { Name = "Safrin", Gender = "Female", Subjects = new List<string> { "Entomology", "Botany" } },  
        new Student() { Name = "Awdhil", Gender = "Male", Subjects = new List<string> { "Computers", "Operating System", "Java" } },  
        new Student() { Name = "Nasiha", Gender ="Female", Subjects = new List<string> { "English", "Social Studies", "Chemistry" } },  
        new Student() { Name = "Hameem", Gender = "Male", Subjects = new List<string> { "Accounting", "Charted" } }  
        };  
            var studentname = Objstudent.OrderBy(x => x.Name);  
            foreach (var student in student name)  
            {  
                Console.WriteLine(student.Name);  
            }  
                Console.ReadLine();  
    }  
}  
    class Student  
    {  
        public string Name { get; set; }  
        public string Gender { get; set; }  
        public List<string> Subjects { get; set; }  
    }  
}  
