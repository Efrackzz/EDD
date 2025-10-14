using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePila
{
    internal class PilaEstatica
    {
        private int max;       // Tamaño máximo de la pila
        private object[] datos; // Arreglo que almacena los elementos
        private int top;        // Índice del último elemento agregado

        // Constructor: inicializa la pila con tamaño máximo
        public PilaEstatica(int tamaño)
        {
            max = tamaño;
            datos = new object[max];
            top = -1; // pila vacía
        }

        // Verifica si la pila está vacía
        public bool EstaVacia()
        {
            return top == -1;
        }

        // Verifica si la pila está llena
        public bool EstaLlena()
        {
            return top == max - 1;
        }

        // Agrega un elemento a la pila
        public void Push(object x)
        {
            if (EstaLlena())
            {
                Console.WriteLine("La pila está llena.");
                return;
            }
            top++;
            datos[top] = x;
        }

        // Elimina y retorna el elemento en la cima de la pila
        public object Pop()
        {
            if (EstaVacia())
            {
                Console.WriteLine("La pila está vacía.");
                return null;
            }
            object valor = datos[top];
            top--;
            return valor;
        }

        // Muestra todos los elementos de la pila
        public void MostrarDatos()
        {
            if (EstaVacia())
            {
                Console.WriteLine("La pila está vacía.");
                return;
            }

            Console.WriteLine("Elementos en la pila:");
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(datos[i]);
            }
        }
    }
}
