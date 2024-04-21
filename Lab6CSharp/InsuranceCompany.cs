using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class InsuranceCompany : Company
    {
        private bool licenseStatus;
        public InsuranceCompany(
            string name,
            int employeeCount,
            decimal capital,
            bool licenseStatus
            ) : base(name, employeeCount, capital)
        {
            Console.WriteLine("Constructor: {0}", GetType().Name);
            this.licenseStatus = licenseStatus;
        }

        public InsuranceCompany(
            string name,
            int employeeCount,
            bool licenseStatus
            ) : this(name, employeeCount, 0, licenseStatus)
        {
        }

        public InsuranceCompany(
            string name,
            int employeeCount
            ) : this(name, employeeCount, 0, false)
        {
        }

        ~InsuranceCompany()
        {
            Console.WriteLine("Destructor InsuranceCompany");
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("License status: {0}\n", this.licenseStatus);
        }
    }
}
