using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionDeCodigoPila
{
    internal class PilaRevision
    {
        private char[] elementos;
        private int top;
        private int max;

        public int Top
        {
            get { return top; }
            set { top = value; }
        }

        public PilaRevision(int tamaño = 100)
        {
            max = tamaño;
            elementos = new char[max];
            top = -1;
        }

        public bool EstaVacia()
        {
            return top == -1;
        }

        public bool EstaLlena()
        {
            return top == max - 1;
        }

        public void Insertar(char x)
        {
            if (!EstaLlena())
            {
                elementos[++top] = x;
            }
        }

        public char Eliminar()
        {
            if (!EstaVacia())
            {
                return elementos[top--];
            }
            return '\0'; // vacío
        }

        public char Tope()
        {
            if (!EstaVacia())
            {
                return elementos[top];
            }
            return '\0';
        }

        public bool Comparar(char x)
        {
            if (x == ')')
                return Tope() == '(';
            else if (x == ']')
                return Tope() == '[';
            else if (x == '}')
                return Tope() == '{';
            else
                return false;
        }
    }
}
