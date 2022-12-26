using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3CSharp
{
    public class Factory : IComparable
    {
        private const string PATHTOTXT = @"..\..\FactoryData";
        private string _name;
        private List<Workshop> _workshops;
        private Dictionary<string, Person> _people;
        private List<Master> _masters;
        private List<Worker> _workers;
        private int _amountOfDetailsWereMade;

        public Factory(Factory factory) // deep copying
        {
            List<Worker> workers = new List<Worker>(5);
            List<Master> masters = new List<Master>(5);
            List<Workshop> workshops = new List<Workshop>(5);
            Dictionary<string, Person> people = new Dictionary<string, Person>(5);
            foreach (var worker in factory.Workers)
            {
                workers.Add(worker);
            }
            foreach (var master in factory.Masters)
            {
                masters.Add(master);
            }
            foreach (var workshop in factory.Workshops)
            {
                workshops.Add(workshop);
            }
            foreach (var person in factory.People)
            {
                people.Add(person.Key, person.Value);
            }
            this._workers = workers;
            this._masters = masters;
            this._workshops = workshops;
            this._people = people;
            this._name = factory.Name;
            this._amountOfDetailsWereMade = factory.AmountOfDetailsWereMade;
        }

        public Factory(string name, IEnumerable<Workshop> workshops, IEnumerable<Person> people)
        {
            this._name = name;
            this._workshops = workshops.ToList();
            Dictionary<string, Person> persons = new Dictionary<string, Person>(5);
            _workers = new List<Worker>(10);
            _masters = new List<Master>(10);
            foreach (var person in people)
            {
                persons.Add(person.UniqeNumber, person);
                if(person is Master)
                {
                    _masters.Add((Master)person);
                }
                if(person is Worker)
                {
                    _workers.Add((Worker)person);
                }
            }
            FillWorkshops(people.ToList());
            this._people = persons;
        }

        public string Name { get => _name; }
        public int AmountOfWorkshops { get => _workshops.Count; }
        public int AmountOfMasters { get => _masters.Count; }
        public int AmountOfWorkers { get => _workers.Count; }
        public List<Workshop> Workshops { get => _workshops; set => _workshops = value; }
        public Dictionary<string, Person> People { get => _people; set => _people = value; }
        public List<Master> Masters { get => _masters; set => _masters = value; }
        public List<Worker> Workers { get => _workers; set => _workers = value; }
        public int AmountOfDetailsWereMade { get => _amountOfDetailsWereMade; set => _amountOfDetailsWereMade = value; }

        public void HirePerson(Person person) // Sorry for complex method
        {
            
            if (person == null)
            {
                throw new NullReferenceException("Person was null");
               
            }
            else if (_people.ContainsKey(person.UniqeNumber))
            {
                throw new ArgumentException("Person with that key alreaedy exists");
            }
            else if (person is Master)
            {
                bool found = false;
                this._masters.Add((Master)person);
                foreach (var item in _workshops)
                {
                    if (item.UniqeNumber == person.WorkerNumberOfWorkshop)
                    {
                        item.CurrentAmountOfMasters += 1;
                        found = true;
                    }
                    break;
                }
                if (!found)
                {
                    _workshops.Add(new Workshop(person.WorkerNumberOfWorkshop, 500, 350, 150, 0, 1, 15, 5, 3000, 6000));
                }
            }
            else if (person is Worker)
            {
                bool found = false;
                this._workers.Add((Worker)person);
                foreach (var item in _workshops)
                {
                    if (item.UniqeNumber == person.WorkerNumberOfWorkshop)
                    {
                        item.CurrentAmountOfWorkers += 1;
                    }
                    break;
                }
                if (!found)
                {
                    _workshops.Add(new Workshop(person.WorkerNumberOfWorkshop, 500, 350, 150, 1, 0, 15, 5, 3000, 6000));
                }
            }
            else
            {
                throw new Exception("Unknown type was in person");
            }

            _people.Add(person.UniqeNumber, person);
        }
        public void FirePerson(string uniqueNumberOfPerson)
        {
            if (!_people.ContainsKey(uniqueNumberOfPerson))
            {
                throw new ArgumentException("Person with that key wasnt found");
            }
            if (_people[uniqueNumberOfPerson] is Master)
            {
                _masters.Remove((Master)_people[uniqueNumberOfPerson]);
                foreach (var workshop in _workshops)
                {
                    if (workshop.UniqeNumber == _people[uniqueNumberOfPerson].WorkerNumberOfWorkshop)
                    {
                        workshop.CurrentAmountOfMasters -= 1;
                    }
                }
            }
            else if (_people[uniqueNumberOfPerson] is Worker)
            {
                _workers.Remove((Worker)_people[uniqueNumberOfPerson]);
                foreach (var workshop in _workshops)
                {
                    if (workshop.UniqeNumber == _people[uniqueNumberOfPerson].WorkerNumberOfWorkshop)
                    {
                        workshop.CurrentAmountOfWorkers -= 1;
                    }
                }
            }
            _people.Remove(uniqueNumberOfPerson);
        }

        public int CompareTo(object? obj) // Will be comparing by total amount of workers
        {
            Factory factory = (Factory)obj;
            if (factory == null)
            {
                throw new InvalidDataException("Argument wasnt factory");
            }
            int totalValueFirstFactory = this.AmountOfMasters + this.AmountOfWorkers + this.AmountOfWorkshops;
            int totalValueSecondFactory = factory.AmountOfMasters + factory.AmountOfWorkers + factory.AmountOfWorkshops;
            if (totalValueFirstFactory > totalValueSecondFactory)
            {
                return 1;
            }
            if (totalValueFirstFactory < totalValueSecondFactory)
            {
                return -1;
            }
            return 0;
        }
        public override string ToString()
        {
            return this._name;
        }
        public string GetInfo()
        {
            string res = $"Name {_name}, Amount of workers {AmountOfWorkers}, Amount of masters {AmountOfMasters}\n";
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("All found masters");
            foreach (var master in _masters)
            {
                stringBuilder.AppendLine($"Uniqe number = {master.UniqeNumber}, Work number {master.WorkerNumberOfWorkshop}," +
                    $" Amount of certificates {master.AmountOfCertificates}, Full name {master.FullName}");
            }
            stringBuilder.AppendLine("All found workers");
            foreach (var worker in _workers)
            {
                stringBuilder.AppendLine($"Uniqe number = {worker.UniqeNumber}, Work number {worker.WorkerNumberOfWorkshop}," +
                $" Does he have education? {worker.HasEducation}, Full name {worker.FullName}");
            }
            stringBuilder.AppendLine("Info about workshops");
            foreach (var workshop in _workshops)
            {
                stringBuilder.AppendLine($"Number of workshop {workshop.UniqeNumber}, current amount of workers working righgt now {workshop.CurrentAmountOfWorkers}\n" +
                    $"Current amount of masters {workshop.CurrentAmountOfMasters} Revenue from one detail {workshop.RevenueOfOneDetail}, Cost of one detail {workshop.CostOfOneDetail}\n" +
                    $"max capacity of people {workshop.MaxCapacity} max capacity of workers {workshop.MaxCapacityOfWorkers}, max capacity of masters {workshop.MaxCapacityOfMasters}");
            }
            res += stringBuilder.ToString();
            return res;
        }
        public void SaveToTXTFactoryGeneral()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("General info factory and workshops");
            stringBuilder.AppendLine($"Name {_name}, Amount of workers {AmountOfWorkers}, Amount of masters {AmountOfMasters}");
            stringBuilder.AppendLine("Info about workshops");
            foreach (var workshop in _workshops)
            {
                stringBuilder.AppendLine($"Number of workshop {workshop.UniqeNumber}, current amount of workers working righgt now {workshop.CurrentAmountOfWorkers}\n" +
                    $"Current amount of masters {workshop.CurrentAmountOfMasters} Revenue from one detail {workshop.RevenueOfOneDetail}, Cost of one detail {workshop.CostOfOneDetail}\n" +
                    $"max capacity of people {workshop.MaxCapacity} max capacity of workers {workshop.MaxCapacityOfWorkers}, max capacity of masters {workshop.MaxCapacityOfMasters}");
            }
            File.WriteAllText($@"{PATHTOTXT}\{_name}.txt", stringBuilder.ToString());
        }
        public void SaveToTXTMasters()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Masters");
            foreach (var master in _masters)
            {
                stringBuilder.AppendLine($"Uniqe number = {master.UniqeNumber}, Work number {master.WorkerNumberOfWorkshop}," +
                    $" Amount of certificates {master.AmountOfCertificates}, Full name {master.FullName}");
            }
            File.WriteAllText($@"{PATHTOTXT}\Masters.txt", stringBuilder.ToString());
        }
        public void SaveToTXTWorkers()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Workers");
            foreach (var worker in _workers)
            {
                stringBuilder.AppendLine($"Uniqe number = {worker.UniqeNumber}, Work number {worker.WorkerNumberOfWorkshop}," +
                $" Does he have education? {worker.HasEducation}, Full name {worker.FullName}");
            }
            File.WriteAllText($@"{PATHTOTXT}\Workers.txt", stringBuilder.ToString());
        }
        public string ReadFileFromPath(string path)
        {
            string text = "";
            using (var reader = new StreamReader(path))
            {
                string line;
                while (((line = reader.ReadLine()) != null))
                {
                    text += $"{line}\n";
                }
            }
            return text;
        }
        private void FillWorkshops(List<Person> people)
        {
            foreach (var workshop in _workshops)
            {
                foreach (var person in people)
                {
                    if (workshop.UniqeNumber == person.WorkerNumberOfWorkshop)
                    {
                        if (person is Master)
                        {
                            workshop.CurrentAmountOfMasters += 1;
                        }
                        else if (person is Worker)
                        {
                            workshop.CurrentAmountOfWorkers += 1;
                        }
                    }
                }
            }
        }
    }
}
