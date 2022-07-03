using System;
using System.Collections.Generic;
using System.Text;

namespace Examen11042022.models
{
    internal abstract class User
    {
        private int id;
        private string dni;
        private string name;
        private string surname;
        private bool active;
        private bool working;

        protected User(int id, string dni, string name, string surname, bool active, bool working)
        {
            this.id = id;
            this.dni = dni;
            this.name = name;
            this.surname = surname;
            this.active = active;
            this.working = working;
        }

        public int Id { get => id; set => id = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public bool Active { get => active; set => active = value; }
        public bool Working { get => working; set => working = value; }

        public abstract string information();
    }
}
