using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Factory : Company
    {
        private string productType;
        public Factory(
            string name,
            int employeeCount,
            decimal capital,
            string productType
            ) : base(name, employeeCount, capital)
        {
            Console.WriteLine("Constructor: {0}", GetType().Name);
            this.productType = productType;
        }

        public Factory(
            string name,
            int employeeCount,
            decimal capital
            ) : this(name, employeeCount, capital, "Universal")
        {
        }

        public Factory(
            string name,
            int employeeCount
            ) : this(name, employeeCount, 0, "Universal")
        {
        }

        ~Factory()
        {
            Console.WriteLine("Destructor Factory");
        }

        public override void Show()
        {
           base.Show();
           Console.WriteLine("Product type: {0}\n", this.productType);
        }
    }
}
