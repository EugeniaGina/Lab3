using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3CSharp
{
    public class Workshop
    {
        private int _uniqeNumber;
        private int _maxCapacity;
        private int _maxCapacityOfWorkers;
        private int _maxCapacityOfMasters;
        private int _currentAmountOfWorkers;
        private int _currentAmountOfMasters;
        private readonly int _amountOfDetailsMasterMakes;
        private readonly int _amountOfDetailsWorkerMakes;
        private readonly int _costOfOneDetail;
        private readonly int _revenueOfOneDetail;
        public Workshop(int uniqeNumber, int maxCapacity, int maxCapacityOfWorkers, int maxCapacityOfMasters,
            int currentAmountOfWorkers, int currentAmountOfMasters, int amountOfDetailsMasterMakes,
            int amountOfDetailsWorkerMakes, int costOfOneDetail, int revenueOfOneDetail)
        {
            Validator(maxCapacity, maxCapacityOfWorkers, maxCapacityOfMasters, currentAmountOfMasters, currentAmountOfWorkers);
            _uniqeNumber = uniqeNumber;
            _maxCapacity = maxCapacity;
            _maxCapacityOfWorkers = maxCapacityOfWorkers;
            _maxCapacityOfMasters = maxCapacityOfMasters;
            _currentAmountOfWorkers = currentAmountOfWorkers;
            _currentAmountOfMasters = currentAmountOfMasters;
            _amountOfDetailsMasterMakes = amountOfDetailsMasterMakes;
            _amountOfDetailsWorkerMakes = amountOfDetailsWorkerMakes;
            _costOfOneDetail = costOfOneDetail;
            _revenueOfOneDetail = revenueOfOneDetail;
        }
        public int UniqeNumber { get => _uniqeNumber; }
        public int MaxCapacity 
        {
            get => _maxCapacity;
            set
            {
                if (value < _maxCapacityOfMasters + _maxCapacityOfMasters)
                {
                    throw new ArgumentException("Max Capacity cant be less than total amount of workers and masters that are working");
                }
                _maxCapacity = value;
            }
        }
        public int MaxCapacityOfWorkers 
        {
            get => _maxCapacityOfWorkers;
            set
            {
                if (value > _maxCapacity - _maxCapacityOfMasters)
                {
                    throw new ArgumentException("Cant add more capacity  workers total capacity is gonna be less");
                }
                _maxCapacityOfWorkers = value;
            }
        }
        public int MaxCapacityOfMasters
        { 
            get => _maxCapacityOfMasters;
            set
            {
                if (value > _maxCapacity - _maxCapacityOfWorkers)
                {
                    throw new ArgumentException("Cant add more capacity for masters total capacity is gonna be less");
                }
                _maxCapacityOfMasters = value;
            }

        }
        public int CurrentAmountOfWorkers
        { 
            get => _currentAmountOfWorkers;
            set
            {
                if(value > _maxCapacityOfWorkers)
                {
                    throw new ArgumentException("Cant add more workers capacity is full");
                }
                _currentAmountOfWorkers = value;
            }
        }
        public int CurrentAmountOfMasters
        { 
            get => _currentAmountOfMasters;
            set
            {
                if (value > _maxCapacityOfMasters)
                {
                    throw new ArgumentException("Cant add more workers capacity is full");
                }
                _currentAmountOfMasters = value;
            }
        }

        public int AmountOfDetailsMasterMakes => _amountOfDetailsMasterMakes;

        public int AmountOfDetailsWorkerMakes => _amountOfDetailsWorkerMakes;

        public int CostOfOneDetail => _costOfOneDetail;

        public int RevenueOfOneDetail => _revenueOfOneDetail;
        private void Validator(int maxCapacity, int maxCapacityWorkers, int maxCapacityMasters, int amountOfMasters, int amountOfWorkers)
        {
            if(maxCapacity < maxCapacityMasters + maxCapacityMasters)
            {
                throw new ArgumentException("Max capacity was less than sum of capacity workers and masters");
            }
            if(maxCapacityWorkers < amountOfWorkers)
            {
                throw new ArgumentException("Amount of workers was more than max max capacity of them");
            }
            if (maxCapacityMasters < amountOfMasters)
            {
                throw new ArgumentException("Amount of masters was more than max max capacity of them");
            }
        }

    }
}
