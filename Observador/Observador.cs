using System;
using System.Collections.Generic;
using System.Text;

namespace PatDeDisObservador
{
    class Observador : IObservador
    {
        private string nombre;
        private Sujeto sujeto;
        public Observador(string pNombre, Sujeto pSujeto)
        {
            nombre = pNombre;
            sujeto = pSujeto;
            sujeto.Suscribir(this);
        }
        //Este metodo es usado por el sujeto en el push
        public void Update(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[Push]=> Hola {0}: {1}", nombre, mensaje);
        }
        //aqui es para el caso pull
        //public void UpdatePull()
        //{
        //    //Obtenemos del sujeto
        //    //puede ir mas logica para decidir cuando hacerlo
        //    int n = sujeto.N;
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine("[Pull]=> Hola {0}-{1}", nombre, n);
        //}
    }
}
