using System;
using System.Threading;

namespace Ejercicio_17
{
    class Program
    {
            //Ejercicio_17
            //Un tipo de valor contiene los datos dentro de su propia asignación de memoria y un tipo de referencia contiene un puntero a otra ubicación de memoria 
            //que contiene los datos reales. Las variables de tipo de referencia se almacenan en el montón, mientras que las variables de tipo de valor se almacenan 
            //en la pila.
            
            //Ejercicio_18
            //Noto que en el momento de ejecutarse el codigo varia los resultados debido a que varia la manera en la que se utilizan los hilos, ya que cuando se 
            //inicia el segundo hilo el computador pierde el control de cual se esta ejecutando priemro
    }
    /*internal static class ThreadTest
    {
        internal static void Main()
        {
            var t = new Thread(WriteY); // Kick off a new thread
            t.Start(); // running WriteY()

            // Simultaneously, do something on the main thread.
            for (var i = 0; i < 1000; i++) Console.Write("x");
        }

        private static void WriteY()
        {
            for (var i = 0; i < 1000; i++) Console.Write("y");
        }*/

        //Ejercicio_19
        internal static class ThreadTest
        {
            static void Main()
            {
                new Thread(Gou).Start();
                Go();
            }

            private static void Go()
            {
                for (var cycles = 0; cycles < 5; cycles++) Console.Write('?');
            }
        private static void Gou()
        {
            for (var cycles = 0; cycles < 5; cycles++) Console.Write('!');
        }
        //¿Cuál es la diferencia entre una clase y un objeto?
        //Una clase es una estructura de programación definida por el usuario mientras que un objeto es un tipo de dato que surge a partir de la clase de programación.
        //¿Cuál es la diferencia entre un método y un hilo?
        //Thread es un tipo de clase que te permite hacer trabajar el codigo en paralelo, mientras que un Task es un conjunto de clases que se utilizan para ejecutar un 
        //codigo de manera asincronica.
        //¿Cuántos flujos de instrucciones puede llegar a tener este programa?
    }

}
