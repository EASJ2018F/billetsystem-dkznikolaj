using System;
using System.Collections.Generic;
using System.Text;

namespace BilletClassLibrary
{
    public abstract class Template
    {
        public DateTime Dato { get; set; }

        public string Nummerplade { get; set; }

        abstract public int Pris();

        abstract public string Køretøj();
    }
}
