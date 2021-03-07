using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] calificacion;
            calificacion = new int[5];


            int promedio = 0;
            int suma = 0;

            int contadoraprob = 0;
            int contadorrep =0;


            for (int i = 0; i <= 4; i++) 
            {
                calificacion[i] = i;
                Console.WriteLine("Calificacion del alumno {0} es: ", i + 1);
                calificacion[i] = int.Parse(Console.ReadLine());

                suma = suma + calificacion[i];
            }


            for (int i = 0; i <= 4; i++)
            {
                if (calificacion[i] < 70)
                {
                    contadorrep++;
                }
                else
                {
                    contadoraprob++;
                }
            }

            promedio = suma / 5;
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("El promedio de todos los estudiantes es: {0}", promedio);
            Console.WriteLine("Numeros de estudiantes aprobados:  {0} ", contadoraprob);
            Console.WriteLine("Numeros de estudiantes reprobados:  {0} ", contadorrep);

            Console.ReadKey();
        }
    }
}
