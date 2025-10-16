using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePila
{
    internal class Pila
    {
        private int contador = 0;

        private int max;//Se utiliza en caso de que la pila sea dinamica

        public int Max
        {
            get { return max; }
            set { max = value; }
        }

        private Nodo top; // referencia al nodo que está en la cima

        public Nodo Top
        {
            get { return top; }
            set { top = value; }
        }

        
        public Pila(int Max)
        {
            top = null; // Se inicializa la pila vacía
            max = Max;//Si la pila no es estatica, se deja Max como -1
        }

        public void Push(object x)
        {
            if (EstaLlena() && max != -1)// Verifica si la pila esta llena y si es estatica
            {
                Console.WriteLine("La pila está llena.");
                return;
            }

            Nodo nuevo = new Nodo(x);   // crea un nuevo nodo
            nuevo.Siguiente = top;      // el nuevo nodo apunta al anterior
            top = nuevo;                // el nuevo nodo se convierte en el tope de la pila
        }

        public object Pop()
        {
            if (EstaVacia())
            {
                Console.WriteLine("La pila está vacía.");
                return null;
            }

            object valor = top.Dato;    // obtiene el dato del tope
            top = top.Siguiente;        // el tope ahora apunta al siguiente nodo
            return valor;
        }

        // Verifica si la pila está vacía
        public bool EstaVacia()
        {
            return top == null;
        }

        //Verifica si la pila esta llena(Solo si es estatica)
        public bool EstaLlena()
        {
            return contador >= max;
        }

        // Muestra todos los elementos de la pila
        public string MostrarDatos()
        {
            if (EstaVacia())
                return "La pila está vacía.";

            string datos = "Elementos en la pila:\n";
            Nodo actual = top;
            while (actual != null)
            {
                datos += actual.Dato + "\n";
                actual = actual.Siguiente;
            }
            return datos;
        }
    }
}
