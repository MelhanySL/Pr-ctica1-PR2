using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                        Punto my_punto = new Punto();
                        Punto my_punto_2 = new Punto(6,8);

                        my_punto.SetX(10);
                        my_punto.SetY(5);

                        my_punto_2.SetX(20);
                        my_punto_2.SetY(45);

                        Console.WriteLine($"Mi valor en x es: {my_punto.GetX()}\nMi valor en y es: {my_punto.GetY()}");
                        Console.WriteLine("Mi valor en x es: {0}\nMi valor en y es: {1}", my_punto_2.GetX(), my_punto_2.GetY());
            */

            Vector my_vector = new Vector(2, 3, 9, 6);
            Vector my_vector_2 = new Vector(7, 1, 9, -3);
            float escalar_1 = 5;

            Vector my_vector_3 = my_vector + my_vector_2;
            //my_vector += my_vector_2;
            Vector my_vector_4 = my_vector - my_vector_2;
            float escalar = my_vector * my_vector_2;
            Vector my_vector_5 = my_vector * escalar_1;

            Console.WriteLine("Vector 1: ");
            my_vector.Mostrar_vector();
            Console.WriteLine($"Magnitud vector 1 es de: {my_vector.Get_magnitud()}");

            Console.WriteLine("\nVector 2: ");
            my_vector_2.Mostrar_vector();
            Console.WriteLine($"Magnitud vector 2 es de: {my_vector_2.Get_magnitud()}");

            Console.WriteLine("\nSuma del vector 1 + vector 2: ");
            my_vector_3.Mostrar_vector();
            Console.WriteLine($"Magnitud del vector: {my_vector_3.Get_magnitud()}");

            Console.WriteLine("\nResta del vector 1 - vector 2: ");
            my_vector_4.Mostrar_vector();
            Console.WriteLine($"Magnitud del vector: {my_vector_4.Get_magnitud()}");

            Console.WriteLine($"\nMultiplicacion Por Punto del vector 1 . vector 2:\n{escalar}\n\n" +
                              $"Multiplicación por un escalar: ");
            my_vector_5.Mostrar_vector();
            Console.WriteLine($"Magnitud del vector: {my_vector_5.Get_magnitud()}");
            
            Console.ReadLine();
        }
    }
}
