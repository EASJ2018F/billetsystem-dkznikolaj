using System;
using System.Dynamic;

namespace BilletClassLibrary
{
    public class Bil
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
           return 240;
        }

        public string Køretøj()
        {
            return "Bil";
        }
    }
}
