using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Company: ICompany
    {
        protected string name;
        protected int employeeCount;
        protected decimal capital;
        public string Name { get => this.name; set => this.name = value; }

        public Company(
            string  name,
            int     employeeCount,
            decimal capital
            )
        {
            Console.WriteLine("Constructor: Company");
            this.name           = name;
            this.employeeCount  = employeeCount;
            this.capital        = capital;
        }

        public Company(
            string name
            ): this(name, 0, 0)
        {
        }

        public Company(
            string name,
            int employeeCount
            ) : this(name, employeeCount, 0)
        {
        }

        ~Company()
        {
            Console.WriteLine("Destructor Company");
        }

        public virtual void Show()  
        {
            string className = GetType().Name;

            Console.WriteLine(
                "Class name: {0}\nName: {1}\nEmployee count: {2}\nCapital: {3}",
                className,
                this.name,
                this.employeeCount,
                this.capital
                );
        }

        public int CompareTo(object? o)
        {
            if (o is Company company) return (int)(this.capital - company.capital);
            else throw new ArgumentException("Incorrent parameter value");
        }
    }
}
