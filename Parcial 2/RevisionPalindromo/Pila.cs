using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionPalindromo
{
    internal class Pila
    {
        private int top;
        private int max;
        private char[] elementos;

        public Pila(int tamaño)
        {
            max = tamaño;
            elementos = new char[max];
            top = -1;
        }

        public bool EstaVacia()
        {
            return top == -1;
        }

        public void Insertar(char x)
        {
            if (top == max - 1)
            {
                Console.WriteLine("La pila está llena");
            }
            else
            {
                top++;
                elementos[top] = x;
            }
        }

        public char Eliminar()
        {
            if (EstaVacia())
            {
                Console.WriteLine("La pila está vacía");
                return '\0';
            }
            else
            {
                char x = elementos[top];
                top--;
                return x;
            }
        }
    }
}
