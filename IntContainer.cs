using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class IntContainer
    {
        int i = -1;
        int[] Container = new int[5];
        int trigger = 0;
        public string aus = "";
        string el;
        public IntContainer()
        {

        }

        public void InserisciElemento(string aus)
        {
            i++;
            if (i == 5) i--; //Evito eccezioni di i

            if (trigger == 1) //Si attiva solo dopo che il container è stato riempito
            {
                //I valori della stringa slittano indietro, il primo valore si perde, l'ultimo verrà rimpiazzato in fase di input
                for (int j = 0; j < (Container.Length - 1); j++)
                {
                    Container[j] = Container[j + 1];
                }

            }

            // INPUT
            el = (Console.ReadLine());
            Console.WriteLine("\n");

            
            if (!int.TryParse(el, out Container[i])) { el = "0"; aus = "&"; } //Prevengo eccezione del Parsing. (Non mi ricordavo come usare il try catch in questo momento)
            Container[i] = int.Parse(el);

            if (i == 4) trigger = 1; //Per controllare che il quinto valore sia stato inserito

        }



        public void StampaContenuto()
        {

            if (i == 4) //Dopo aver riempito il container, ad ogni nuova acquisizione, stampa tutto il container aggiornato
            {
                foreach (int element in Container)
                {
                    Console.Write(element + " ");
                }

                Console.WriteLine("\n\n");
            }
          /*else
            {
                Console.WriteLine($"Inserisci ancora {Container.Length - i -1} numeri per riempire il container");
            }*/
        }

    }
}
