using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseFila
{
    internal class FilaDinamica
    {
        private Nodo frente;  // primer elemento (sale primero)
        private Nodo final;   // último elemento (entra último)

        // Constructor: inicializa la fila vacía
        public FilaDinamica()
        {
            frente = null;
            final = null;
        }

        // Verificar si está vacía
        public bool EstaVacia()
        {
            return frente == null;
        }

        // Insertar: agregar al final
        public void Insertar(object x)
        {
            Nodo nuevo = new Nodo(x);

            if (EstaVacia())
            {
                frente = nuevo;
                final = nuevo;
            }
            else
            {
                final.Siguiente = nuevo;
                final = nuevo;
            }
        }

        // Eliminar: sacar del frente
        public object Eliminar()
        {
            if (EstaVacia())
            {
                Console.WriteLine("La fila está vacía.");
                return null;
            }

            object valor = frente.Dato;
            frente = frente.Siguiente;

            if (frente == null) // si la fila quedó vacía
                final = null;

            return valor;
        }

        // Mostrar los datos de la fila
        public string MostrarDatos()
        {
            if (EstaVacia())
                return "La fila está vacía.";

            string datos = "Elementos en la fila:\n";
            Nodo actual = frente;
            while (actual != null)
            {
                datos += actual.Dato + "\n";
                actual = actual.Siguiente;
            }
            return datos;
        }

        // En una fila dinámica, nunca se llena
        public bool EstaLlena()
        {
            return false;
        }
    }
}
