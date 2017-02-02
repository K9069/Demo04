using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personapplication
{
    class Teacher : Person
    {
        public string Room { get; set; }

        // default constructor
        public Teacher()
        {
        }

        // parametric constuctor calls base class constructor with parameters
        public Teacher(string firstname, string lastname, string room)
            : base(firstname, lastname)
        {
            Room = room;
        }

        // just one method what Teacher can do 
        public void TeacherMethod()
        {
            Console.WriteLine("This method belongs to Teacher!");
        }

        // override base class ToString()-method
        public override string ToString()
        {
            // base on tässä tapauksessa Person-luokka
            // "eli" kutsutaan Person-loukan ToString().metodia
            // return Firstname + " " + Lastname + " " + Room;
            return base.ToString() + " " + Room;
        }
    }
}