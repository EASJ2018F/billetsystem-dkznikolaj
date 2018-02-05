using System;
using System.Dynamic;

namespace BilletClassLibrary
{
    public class Bil : Template
    {
        private DateTime _dato;

        private string _nummerplade;

        public new DateTime Dato
        {
            get { return _dato; }
            set { _dato = value; }
        }

        
        public new string Nummerplade
        {
            get { return _nummerplade; }
            set
            {
                if (value.Length <= 7) _nummerplade = value; 
                else throw new ArgumentException("Too many characters. Keep it 7 or below.");
            }
        }

        public override int Pris()
        {
           return 240;
        }

        public override string Køretøj()
        {
            return "Bil";
        }
    }
}
