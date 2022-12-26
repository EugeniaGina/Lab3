using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3CSharp
{
    public class Master : Person
    {
        public const decimal SALARY = 40000; // grn
        public int AmountOfCertificates { get; set; }
        public Master(int amountOfCertificates, string fullName, string uniqeNumber, int workerNumberOfShop)
        {
            AmountOfCertificates = amountOfCertificates;
            base.FullName = fullName;
            base.UniqeNumber = uniqeNumber;
            base.WorkerNumberOfWorkshop = workerNumberOfShop;
        }
    }
}
