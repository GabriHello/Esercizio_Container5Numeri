using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contenitore
{
    class IntContainerListSoluzione
    {
        private readonly static int LIST_SIZE = 5;
        private List<int> list;
        public IntContainerListSoluzione()
        {
            list = new List<int>();
        }

        internal void InserisciElemento(int number)
        {
            if (list.Count > LIST_SIZE)
                list.RemoveAt(0);

            list.Add(number);
        }
        internal void StampaContenuto()
        {
            var i = 0;
           foreach(var e in list)
            {
                Console.WriteLine($"{i++} - {e}");
            }
        }


    }
}
