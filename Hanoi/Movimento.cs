using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi
{
    public class Movimento
    {
        public Stack Pino1 { get; set; }
        public Stack Pino2 { get; set; }
        public Stack Pino3 { get; set; }

        public Movimento()
        {
            Pino1 = new Stack();
            Pino2 = new Stack();
            Pino3 = new Stack();

            Pino1.Push(3);
            Pino1.Push(2);
            Pino1.Push(1);


        }

        public int Mover(Stack origem, Stack destino)
        {
            destino.Push(origem.Pop());
            return origem.Count;
        }

        public bool ComparaDiscos(Stack origem, Stack destino)
        {
            if (Convert.ToInt32(origem.Peek()) < Convert.ToInt32(destino.Peek()))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
