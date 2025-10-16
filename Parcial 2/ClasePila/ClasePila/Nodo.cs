using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePila
{
    internal class Nodo
    {
        public object Dato { get; set; }       // Valor que almacena el nodo
        public Nodo Siguiente { get; set; }    // Enlace al siguiente nodo

        public Nodo(object dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}
