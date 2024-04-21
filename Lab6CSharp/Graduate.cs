using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Graduate: Person
    {
        protected string faculty;

        public Graduate(
            string name,
            int birthdate,
            string faculty
            ) : base(name, birthdate)
        {
            this.faculty = faculty;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Faculty: {0}", faculty);
        }
    }
}
