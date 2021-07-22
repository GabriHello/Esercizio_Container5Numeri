using System;

namespace Contenitore
{
    class ProgramSoluzione
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hello world!");

            var _command = "";

            var _container = new IntContainerSoluzione();

            do
            {
                _command = Console.ReadLine();


                try
                {
                    int number = int.Parse(_command);
                    _container.InserisciElemento(number);
                    _container.StampaContenuto();
                }
                catch (FormatException eccezione)
                {
                    if (_command != "$")
                        Console.WriteLine("Valore non riconosciuto come numero");
                    Console.WriteLine(eccezione.Message);
                    Console.WriteLine(eccezione.StackTrace);
                }


            } while (_command != "$");


        }
    }
}
