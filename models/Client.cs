using System;
using System.Collections.Generic;
using System.Text;

namespace Examen11042022.models
{
    internal class Client : User
    {
        private string startDate;
        private string endDate;
        private double fee;

        public Client(int id, string dni, string name, string surname, bool active, bool working, string startDate, string endDate, double fee)
            : base(id, dni, name, surname, active, working)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Fee = fee;
        }

        public string StartDate { get => startDate; set => startDate = value; }
        public string EndDate { get => endDate; set => endDate = value; }
        public double Fee { get => fee; set => fee = value; }

        public override string information()
        {
            return $"{Name} {Surname}";
        }
    }
}
