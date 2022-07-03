using System;
using System.Collections.Generic;
using System.Text;

namespace Examen11042022.models
{
    internal class Worker: User, Contract
    {
        private string dateOfContract;
        private string work;
        private string round;
        private string startDateOfContract;
        private string endDateOfContract;
        private float salary;

        public Worker(int id, string dni, string name, string surname, bool active, bool working, string dateOfContract, string work, string round)
            : base(id, dni, name, surname, active, working)
        {
            this.dateOfContract = dateOfContract;
            this.work = work;
            this.round = round;
        }

        public string DateOfContract { get => dateOfContract; set => dateOfContract = value; }
        public string Work { get => work; set => work = value; }
        public string Round { get => round; set => round = value; }
        public string StartDateOfContract { get => startDateOfContract; set => startDateOfContract = value; }
        public string EndDateOfContract { get => endDateOfContract; set => endDateOfContract = value; }
        public float Salary { get => salary; set => salary = value; }
        string Contract.startDateOfContract { get => StartDateOfContract; set => StartDateOfContract = value; }
        string Contract.endDateOfContract { get => EndDateOfContract; set => EndDateOfContract = value; }
        float Contract.salary { get => Salary; set => Salary = value; }

        public override string information()
        {
            return $"{Name} {Surname}";
        }
    }
}
