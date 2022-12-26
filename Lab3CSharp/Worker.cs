using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3CSharp
{
    public class Worker : Person
    {
        public const decimal SALARY = 15000; // grn
        public bool HasEducation { get; set; }
        public Worker(bool hasEducation, string fullName, string uniqeNumber, int workerNumberOfShop)
        {
            HasEducation = hasEducation;
            base.FullName = fullName;
            base.UniqeNumber = uniqeNumber;
            base.WorkerNumberOfWorkshop = workerNumberOfShop;
        }
    }
}
