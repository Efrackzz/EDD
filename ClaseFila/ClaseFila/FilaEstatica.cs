using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseFila
{
    internal class FilaEstatica
    {
        private object[] elementos; // arreglo que guarda los datos
        private int frente;          // posición del primer elemento
        private int final;           // posición del último elemento
        private int max;             // tamaño máximo

        // Constructor
        public FilaEstatica(int tamaño)
        {
            max = tamaño;
            elementos = new object[max];
            frente = -1; // la fila empieza vacía
            final = -1;
        }

        // Método para verificar si está vacía
        public bool EstaVacia()
        {
            return frente == -1;
        }

        // Método para verificar si está llena
        public bool EstaLlena()
        {
            return final == max - 1;
        }

        // Método para encolar (insertar al final)
        public void Encolar(object x)
        {
            if (EstaLlena())
            {
                Console.WriteLine("La fila está llena, no se puede agregar más elementos.");
                return;
            }

            if (frente == -1)
                frente = 0; // primer elemento

            final++;
            elementos[final] = x;
        }

        // Método para desencolar (sacar del frente)
        public object Desencolar()
        {
            if (EstaVacia())
            {
                Console.WriteLine("La fila está vacía.");
                return null;
            }

            object valor = elementos[frente];

            // Si el frente y final son iguales, la fila queda vacía
            if (frente == final)
            {
                frente = -1;
                final = -1;
            }
            else
            {
                frente++;
            }

            return valor;
        }

        // Mostrar todos los elementos de la fila
        public string MostrarDatos()
        {
            if (EstaVacia())
                return "La fila está vacía.";

            string datos = "Elementos en la fila:\n";
            for (int i = frente; i <= final; i++)
            {
                datos += elementos[i] + "\n";
            }
            return datos;
        }
    }
}
