using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Malnati_Lab05
{
    class Immobile
    {
        public string Indirizzo { get; private set; }
        public string Contratto { get; private set; }
        public string Tipologia { get; private set; }
        public double Prezzo { get; private set; }
        public int Superficie { get; private set; }
        public int Piano { get; private set; }
        public Immobile(string indirizzo, string contratto, string tipologia, double prezzo, int superficie, int piano)
        {
            Indirizzo = indirizzo;
            Contratto = contratto;
            Tipologia = tipologia;
            Prezzo = prezzo;
            Superficie = superficie;
            Piano = piano;
        }
    }
}
