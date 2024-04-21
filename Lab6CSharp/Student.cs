using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Student : Graduate
    {
        protected int course;

        public Student(
            string name,
            int birthdate,
            string faculty,
            int course
            ) : base(name, birthdate, faculty)
        {
            this.course = course;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Course: {0}", course);
        }
    }
}
