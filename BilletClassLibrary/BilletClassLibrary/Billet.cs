using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BilletClassLibrary
{
    public class Billet
    {
        public bool brobizz;
        private double _pris = 120;

        public double Pris
        {
            get {
                if (brobizz == true) return _pris *= 0.95;
                else return _pris; 
            }
            set { _pris = value; }
        }
    }
}
