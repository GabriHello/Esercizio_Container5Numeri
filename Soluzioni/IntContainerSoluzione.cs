using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contenitore
{
    class IntContainerSoluzione
    {
        static private int LIST_SIZE = 5;
        private int?[] list; //il PUNTO INTERROGATIVO serve a contemplare il valore null
        private int i_next;
        public IntContainerSoluzione()
        {
            list = new int?[LIST_SIZE];
            i_next = 0;
        }

        internal void InserisciElemento(int number)
        {
            list[i_next] = number;
            i_next = (i_next + 1) % LIST_SIZE; //quando il resto è zero ricomincia dall'inizio dell'array
        }
        internal void StampaContenuto()
        {
            var i = i_next;
            var c = 0;
            while (c < LIST_SIZE)
            {
                if (list[i].HasValue)
                {
                    Console.WriteLine($"{c} - {list[i]}");
                }
                i = (i + 1) % LIST_SIZE;
                c++;
            }
        }


    }
}
