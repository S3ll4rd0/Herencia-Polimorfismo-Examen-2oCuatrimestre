using System;
using System.Collections.Generic;
using System.Text;

namespace Examen11042022.models
{
    internal class Trainer : User, Contract
    {
        private List<string> isMonitorOf;
        private string startDateOfContract;
        private string endDateOfContract;
        private float salary;

        public Trainer(int id, string dni, string name, string surname, bool active, bool working, 
            List<string> isMonitorOf, string startDateOfContract, string endDateOfContract, float salary) 
            : base(id, dni, name, surname, active, working)
        {
            this.isMonitorOf = isMonitorOf;
            this.StartDateOfContract = startDateOfContract;
            this.EndDateOfContract = endDateOfContract;
            this.Salary = salary;
        }

        public List<string> IsMonitorOf { get => isMonitorOf; set => isMonitorOf = value; }

        string Contract.startDateOfContract { get => StartDateOfContract; set => StartDateOfContract = value; }
        string Contract.endDateOfContract { get => EndDateOfContract; set => EndDateOfContract = value; }
        float Contract.salary { get => Salary; set => Salary = value; }
        public string StartDateOfContract { get => startDateOfContract; set => startDateOfContract = value; }
        public string EndDateOfContract { get => endDateOfContract; set => endDateOfContract = value; }
        public float Salary { get => salary; set => salary = value; }

        public override string information()
        {
            return $"{Name} {Surname}";
        }

        public double getTotalSalary(int hours)
        {
            int price = 5;
            return hours * price;
        }
    }
}
