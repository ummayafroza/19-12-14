using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<Student> studentStack = new Stack<Student>();
            Student aStudent = new Student();
            aStudent.firstName = "orthy";
            aStudent.lastName = "afroza";
            studentStack.Push(aStudent);
            Student anotherStudent = new Student();
            anotherStudent.firstName = "Ummay";
            anotherStudent.lastName = "afroza";
            studentStack.Push(anotherStudent);
            foreach (Student student  in studentStack)
            {
                Console.WriteLine(student.GetFullName());
            }
            Console.ReadKey();
        }
    }
}
