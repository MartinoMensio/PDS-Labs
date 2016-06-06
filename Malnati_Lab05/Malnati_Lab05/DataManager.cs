using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Malnati_Lab05
{
    class DataManager
    {
        public List<Immobile> immobili { get; private set; }
        public DataManager(string fileName)
        {
            var reader = new StreamReader(File.OpenRead(fileName));
            immobili = new List<Immobile>();
            // first line is "header", i discard it
            var line = reader.ReadLine();
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                var values = line.Split(';');

                string indirizzo = values[0];
                string contratto = values[1];
                string tipologia = values[2];
                double prezzo = double.Parse(values[3]);
                int superficie = int.Parse(values[4]);
                int piano = int.Parse(values[5]);
                immobili.Add(new Immobile(indirizzo, contratto, tipologia, prezzo, superficie, piano));
            }
        }
        public List<Immobile> filter(string indirizzo, string contratto, string tipologia, double prezzo, int superficieMinima, int piano)
        {
            List<Immobile> result = immobili;
            if (!indirizzo.Equals(""))
            {
                result = result.Where(immobile => immobile.Indirizzo.Contains(indirizzo)).ToList<Immobile>();
            }
            if (!contratto.Equals(""))
            {
                result = result.Where(immobile => immobile.Contratto.Equals(contratto)).ToList<Immobile>();
            }
            if (!tipologia.Equals(""))
            {
                result = result.Where(immobile => immobile.Tipologia.Equals(tipologia)).ToList<Immobile>();
            }
            if (!prezzo.Equals(0d))
            {
                result = result.Where(immobile => immobile.Prezzo.Equals(prezzo)).ToList<Immobile>();
            }
            if (!superficieMinima.Equals(0))
            {
                result = result.Where(immobile => immobile.Superficie > superficieMinima).ToList<Immobile>();
            }
            if (!piano.Equals(0))
            {
                result = result.Where(immobile => immobile.Piano.Equals(piano)).ToList<Immobile>();
            }

            return result;
        }
    }
}
