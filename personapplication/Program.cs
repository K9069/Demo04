using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personapplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create one teacher from Teacher class
            Teacher teacher = new Teacher();
            teacher.Firstname = "Matti";
            teacher.Lastname = "Matikka";
            teacher.Address = "Jaakatu 3";
            teacher.Age = 30;
            teacher.PhoneNumber = "0123456789";
            teacher.Room = "D456";
            Console.WriteLine(teacher.ToString());

            // create one student from Student class

            Student student = new Student("Paavo", "Päivä", "K1234");
            student.Address = "Juukatu 4";
            student.Age = 20;
            student.PhoneNumber = "0987654321";
            Console.WriteLine(student.ToString());

            teacher.TeacherMethod();
            student.StudentMethod();
        }
    }
}
