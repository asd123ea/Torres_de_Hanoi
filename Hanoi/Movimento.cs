using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi
{
    public class Movimento
    {
        public List<int> Pino1 { get; set; }
        public List<int> Pino2 { get; set; }
        public List<int> Pino3 { get; set; }

        public Movimento()
        {
            Pino1 = new List<int>() 
            { 
                1,2,3
            };

            Pino3 = new List<int>();
            Pino2 = new List<int>();

        }

        public int Mover(List<int> origem, List<int> destino)
        {
            destino.Add(origem[0]);
            origem.RemoveAt(0);

            return origem.Count;
        }
    }
}
