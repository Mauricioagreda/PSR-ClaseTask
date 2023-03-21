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
        }
        public static void Saludos()
        {
            for (int i = 0; i < 500; i++)
            {
                Console.WriteLine($"Hola {i}");
            }
        }
    }
}
