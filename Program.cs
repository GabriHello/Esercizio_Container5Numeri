using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("\n Inserire dei numeri, verranno salvati solo gli ultimi 5");

            IntContainer stampaContainer = new IntContainer();

            string aus = ""; //non so come prendere questo valore dalla classe

            while (aus != "$")
            {
                stampaContainer.InserisciElemento(aus);
                stampaContainer.StampaContenuto();
            }



        }
    }
}
