using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayWithStudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[3];
            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();

            student1.regNo = 12345;
            student1.firstName = "Mohaiminul";
            student1.lastName = "Islam";
            students[0] = student1;
            
            student2.regNo = 12355;
            student2.firstName = "Tahmina";
            student2.lastName = "Runa";
            students[1] = student2;
           
            student3.regNo = 4445;
            student3.firstName = "Orthy";
            student3.lastName = "Afroza";
            students[2] = student3;
            foreach (Student aStudent in students)
            {
                Console.WriteLine(aStudent.GetFullName()+ " \n His/Her RegNO is: " +aStudent.regNo);

            }
            Console.ReadKey();

        }
    }
}
