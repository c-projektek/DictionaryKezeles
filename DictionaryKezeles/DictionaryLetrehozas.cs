using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryKezeles
{
    public class DictionaryLetrehozas
    {
        public static Dictionary<string, int> StringIntDictionaryListabol(List<string[]> lista, int pozicio)
        {
            List<string> stringLista = new List<string>();

            foreach (string[] item in lista)
            {
                stringLista.Add(item[pozicio]);
            }

            Dictionary<string, int> konyvtar = new Dictionary<string, int>();

            foreach (string item in stringLista)
            {
                bool vanE = true;

                foreach (KeyValuePair<string, int> elem in konyvtar)
                {
                    int ertek = elem.Value;

                    if (item == elem.Key)
                    {
                        ertek++;
                        konyvtar.Remove(item);
                        konyvtar.Add(item, ertek);
                        vanE = false;
                        break;
                    }
                }

                if (vanE)
                {
                    konyvtar.Add(item, 1);
                }
            }

            return konyvtar;
        }
    }
}
