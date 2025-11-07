using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseFila
{
    internal class Nodo
    {
        public object Dato { get; set; }       // Valor almacenado
        public Nodo Siguiente { get; set; }    // Apunta al siguiente nodo

        public Nodo(object dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}
