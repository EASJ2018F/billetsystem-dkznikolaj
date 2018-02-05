using System;
using System.Collections.Generic;
using System.Text;

namespace BilletClassLibrary
{
    public class MC : Template
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
            set { _nummerplade = value; }
        }

        public override int Pris()
        {
            return 125;
        }

        public override string Køretøj()
        {
            return "MC";
        }
    }
}
