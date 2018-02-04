using System;
using System.Collections.Generic;
using System.Text;

namespace BilletClassLibrary
{
    public class MC
    { 
        private DateTime _dato;
        private string _nummerplade;

        public DateTime Dato
        {
            get { return _dato; }
            set { _dato = value; }
        }

        public string Nummerplade
        {
            get { return _nummerplade; }
            set { _nummerplade = value; }
        }

        public int Pris()
        {
            return 125;
        }

        public string Køretøj()
        {
            return "MC";
        }
    }
}
