using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_02
{
    class Vector
    {
        Punto origen;
        Punto fin;
        double magnitud;
        public Vector()
        {
            origen = new Punto(0,0);
            fin = new Punto(1, 1);
            Calcular_magnitud();
        }

        public Vector(Punto _origen, Punto _fin)
        {
            origen = new Punto(_origen.GetX(),_origen.GetY());
            fin = new Punto(_fin.GetX(), _fin.GetY());
            Calcular_magnitud();
        }

        public Vector(float x_origen, float y_origen, float x_fin, float y_fin)
        {
            origen = new Punto(x_origen,y_origen);
            fin = new Punto(x_fin, y_fin);
            Calcular_magnitud();
        }

        private void Calcular_magnitud()
        {
            magnitud = Math.Sqrt(Math.Pow((fin.GetX() - origen.GetX()),2) + Math.Pow((fin.GetY() - origen.GetY()),2));
        }

        public double Get_magnitud()
        {
            return magnitud;
        }

        public void Mostrar_vector()
        {
            Console.WriteLine($"Origen: ({origen.GetX()}) , ({origen.GetY()}) - Fin: ({fin.GetX()}) , ({fin.GetY()})");
        }
        
        public void Set_origen(Punto _origen)
        {
            origen = new Punto(_origen.GetX(), _origen.GetY());
            Calcular_magnitud();
        }

        public void Set_origen(float x, float y)
        {
            origen = new Punto(x,y);
            Calcular_magnitud();
        }
        //Set Punto fin que recibe un punto
        public void Set_fin(Punto _fin)
        {
            fin = new Punto(_fin.GetX(), _fin.GetY());
            Calcular_magnitud();
        }
        //Set Punto fin que recibe dos coordenadas
        public void Set_fin(float x, float y)
        {
            fin = new Punto(x,y);
            Calcular_magnitud();
        }

        public static Vector operator +(Vector sumando1, Vector sumando2)
        {
            Punto nuevo_origen = new Punto(sumando1.origen.GetX() + sumando2.origen.GetX(),
                                           sumando1.origen.GetY() + sumando2.origen.GetY());

            Punto nuevo_fin = new Punto(sumando1.fin.GetX() + sumando2.fin.GetX(),
                                        sumando1.fin.GetY() + sumando2.fin.GetY());

            return new Vector(nuevo_origen, nuevo_fin);            
        }
        //Sobrecarga del operador de resta 
        public static Vector operator -(Vector minuendo, Vector sustraendo)
        {
            Punto nuevo_origen = new Punto(minuendo.origen.GetX() - sustraendo.origen.GetX(),
                                           minuendo.origen.GetY() - sustraendo.origen.GetY());

            Punto nuevo_fin = new Punto(minuendo.fin.GetX() - sustraendo.fin.GetX(),
                                        minuendo.fin.GetY() - sustraendo.fin.GetY());

            return new Vector(nuevo_origen, nuevo_fin);
        }
        //Sobrecarga del operador de multiplicacion por un escalar
        public static Vector operator *(Vector vector, float escalar)
        {
            Punto nuevo_origen = new Punto(vector.origen.GetX() * escalar,
                                           vector.origen.GetY() * escalar);

            Punto nuevo_fin = new Punto(vector.fin.GetX() * escalar,
                                        vector.fin.GetY() * escalar);

            return new Vector(nuevo_origen, nuevo_fin);
        }
        //Sobrecarga del operador de multiplicacion por un vector
        public static float operator *(Vector vector_1, Vector vector_2)
        {
            float escalar;
            vector_1 = vector_1.Vector_verdadero();
            vector_2 = vector_2.Vector_verdadero();

            escalar = (vector_1.fin.GetX() * vector_2.fin.GetX()) + (vector_1.fin.GetY() * vector_2.fin.GetY());
            
            return escalar;
        }

        public Vector Vector_verdadero()
        {
            Punto nuevo_origen = new Punto(0,0);
            Punto nuevo_fin = new Punto(fin.GetX() - origen.GetX() ,
                                        fin.GetY() - origen.GetY());

            return new Vector(nuevo_origen, nuevo_fin);
        }
    }
}
