using System;
using System.Collections.Generic;
using System.Text;

namespace Examen11042022.models
{
    internal interface Contract
    {
        public string startDateOfContract { get; set; }

        public string endDateOfContract { get; set; }

        public float salary { get; set; }
    }
}
