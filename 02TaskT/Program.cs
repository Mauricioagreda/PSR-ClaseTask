using System;
using System.Threading.Tasks;

namespace _02TaskT
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<long> tarea = Task<long>.Run(() => SumaAleatoria());
            System.Console.WriteLine($"Comienza tarea y su estado es: {tarea.Status}");
            tarea.Wait();
            Console.WriteLine($"Terminó tarea con resultado {tarea.Result} y estado {tarea.Status}");
        }
        public static long SumaAleatoria()
        {
            Random r = new Random(DateTime.Now.Millisecond);
            long acumulador = 0;
            for (int i = 0; i < 10000; i++)
            {
                acumulador = acumulador + r.Next(0, 1000);
            }
            return acumulador;
        }
    }
}
