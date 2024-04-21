using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Teacher : Graduate
    {
        protected string position;
        protected int experience;

        public Teacher(
            string name,
            int birthdate,
            string faculty,
            string position,
            int experience
            ) : base(name, birthdate, faculty)
        {
            this.position   = position;
            this.experience = experience;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Position: {0}\nExperience: {1}", position, experience);
        }
    }
}
