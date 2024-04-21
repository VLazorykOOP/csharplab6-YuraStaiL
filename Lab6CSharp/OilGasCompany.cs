using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class OilGasCompany : Company
    {
        private int reserves;
        public OilGasCompany(
            string name,
            int employeeCount,
            decimal capital,
            int reserves
            ) : base(name, employeeCount, capital)
        {
            Console.WriteLine("Constructor: {0}", GetType().Name);
            this.reserves = reserves;
        }

        public OilGasCompany(
            string name,
            int employeeCount
            ) : this(name, employeeCount, 0, 0)
        {
        }

        public OilGasCompany(
            string name,
            int employeeCount,
            int reserves
            ) : this(name, employeeCount, 0, reserves)
        {
        }

        ~OilGasCompany()
        {
            Console.WriteLine("Destructor OilGasCompany");
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Reserves: {0}\n", this.reserves);
        }
    }
}
