
# INVESTIGACION DE CONCEPTOS DE ESTRUCTURA DE DATOS
## Alumno: Efrain Cepeda Nuñez

Una estructura de datos es un formato especializado para organizar, 
procesar y almacenar datos en la memoria de una computadora. 
Permite el acceso y la manipulación eficiente de los datos, facilitando 
operaciones como búsquedas, inserciones y modificaciones. Existen 
diferentes tipos de estructuras de datos:
- Arreglos
   -Vectores
   -Matrices
- Pilas
- Colas
- Listas Enlazadas  
   - Simples
   - Dobles
   - CircularesS

### Arreglos
- #### Los vectores
      Los vectores son una estructura de datos estática que almacena elementos del mismo tipo  
	  en posiciones consecutivas de memoria. En C#, los vectores tienen un tamaño fijo una vez  
	  creados, a diferencia de otros lenguajes como Python donde pueden ser dinámicos.  
	  Un vector puede verse como una columna o lista ordenada de valores.

- #### Las Matrices.
      Las matrices son estructuras de datos que permiten almacenar múltiples elementos del  
	  mismo tipo en una colección ordenada de una o más dimensiones.  
	  Cada elemento se identifica mediante un índice o conjunto de índices, según la  
	  dimensión de la matriz. 
### Pilas
    Una pila en C# es una estructura de datos que sigue el principio LIFO (Last In, First Out), 
    es decir, el último elemento que se agrega es el primero en salir. Imagina una pila de 
    libros: el último libro que colocas en la parte superior será el primero que retires.

   En C#, la clase Stack<T> del espacio de nombres System.Collections.Generic se utiliza para
   implementar pilas. Algunas de las operaciones principales que puedes realizar con una pila 
   son:

   - Push: Agregar un elemento a la pila.
   - Pop: Eliminar y devolver el elemento en la parte superior de la pila.
   - Peek: Ver el elemento en la parte superior sin eliminarlo.
   - Count: Obtener el número de elementos en la pila.
``` C#
 // Crear una pila de enteros
        Stack<int> pila = new Stack<int>();

        // Agregar elementos a la pila
        pila.Push(10);
        pila.Push(20);
        pila.Push(30);

        // Mostrar el elemento en la parte superior
        Console.WriteLine("Elemento en la cima: " + pila.Peek());

        // Eliminar un elemento (Pop)
        Console.Writ
```


### Colas
   Una cola en C# es una estructura de datos que sigue el principio FIFO (First In, First Out),
	lo que significa que el primer elemento que entra es el primero en salir. Es ideal para
	situaciones donde los datos deben procesarse en el mismo orden en que se reciben, como en
	sistemas de impresión o manejo de tareas.

	En C#, las colas se implementan mediante la clase Queue<T>, donde T representa el tipo de
	datos que almacenará la cola. Esta clase pertenece al espacio de nombres
	System.Collections.Generic.

   Características principales de una Cola:
   - Ordenada: Los elementos se almacenan en el orden en que se agregan.
   - Operaciones principales:
       - Enqueue(T item): Agrega un elemento al final de la cola.
       - Dequeue(): Elimina y devuelve el elemento al frente de la cola.
       - Peek(): Devuelve el elemento al frente de la cola sin eliminarlo.

Uso común: Procesamiento de datos en secuencia, como tareas en espera o flujos de datos.
```C#
// Crear una cola de enteros
        Queue<int> cola = new Queue<int>();

        // Agregar elementos a la cola
        cola.Enqueue(10);
        cola.Enqueue(20);
        cola.Enqueue(30);

        // Mostrar el primer elemento sin eliminarlo
        Console.WriteLine("Primer elemento: " + cola.Peek());



```


### Listas Enlazadas
  - #### Simples
	Una lista simplemente enlazada es una estructura de datos lineal similar a los arreglos,
	pero con la diferencia de que sus elementos se encuentran enlazados entre sí mediante
	punteros, en lugar de estar en posiciones de memoria consecutivas.

	Gracias a esto, una lista simplemente enlazada tiene un tamaño dinámico, lo que
	significa que puede crecer o reducirse durante la ejecución del programa mientras exista
	memoria disponible en el sistema.
  - #### Dobles
	En una lista doblemente enlazada, cada nodo contiene una referencia al siguiente y al
	anterior, permitiendo recorrer la lista en ambas direcciones.
  - #### Circulares
	En una lista circular, el último nodo apunta al primero, formando un ciclo continuo que
	permite recorrer la lista sin llegar a un final definido.
  
 
