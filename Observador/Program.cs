using PatDeDisObservador;
using System;


namespace PatDeDisObservador
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos el sujeto
            Sujeto miSujeto = new Sujeto();

            //creamos a los observadores
            Observador a = new Observador("Erick", miSujeto);
            Observador b = new Observador("Brayan", miSujeto);
            Observador c = new Observador("Miguel", miSujeto);
            Observador d = new Observador("Jefry", miSujeto);

            ////TRABAJAMOS
            //for (int n = 0; n < 5; n++)
            //    miSujeto.Trabajo();


            ////alguien se sale de la lista
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("---- Descubir ----");

            miSujeto.Desuscribir(b);

            //trabajamos
            for (int n = 0; n < 5; n++)
            {
                miSujeto.Trabajo();
            }

        }
    }
}
