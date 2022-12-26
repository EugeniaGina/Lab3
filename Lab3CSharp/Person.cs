using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3CSharp
{
    public abstract class Person
    {
        protected string uniqeNumber;
        public string FullName { get; set; }
        public string UniqeNumber 
        {
            get => uniqeNumber;
            set
            {
                if(value.Length != 10 || !long.TryParse(value, out long number))
                {
                    throw new ArgumentException("Key must be 10 numbers long");
                }
                uniqeNumber = value;
            }
                
        }
        public int WorkerNumberOfWorkshop { get; set; }
    }
}
