using System;
using System.Threading.Tasks;

namespace _01Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Task tarea = Task.Run( () => Saludos() );
            tarea.Wait();
            Console.WriteLine();
            Task suma = Task.Run( () => Suma(1, 2) );

            Console.WriteLine();
            suma.Wait();

            Console.ReadKey();
        }
        public static void Saludos()
        {
            for (int i = 0; i < 500; i++)
            {
                Console.WriteLine($"Hola {i}");
            }
        }
        public static int Suma(int a, int b) => a + b;
    }
}
