namespace RevisionPalindromo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una palabra: ");
            string palabra = Console.ReadLine();

            Pila pilaPalindromo = new Pila(palabra.Length);

            // Insertar cada letra en la pila
            for (int i = 0; i < palabra.Length; i++)
            {
                char x = palabra[i];
                pilaPalindromo.Insertar(x);
            }

            string otraPalabra = "";

            // Eliminar de la pila para formar la palabra invertida
            while (!pilaPalindromo.EstaVacia())
            {
                char x = pilaPalindromo.Eliminar();
                otraPalabra += x;
            }

            // Comparar las palabras
            if (palabra == otraPalabra)
                Console.WriteLine("La palabra " + palabra + " es un palíndromo");
            else
                Console.WriteLine("La palabra " + palabra + " no es un palíndromo");
        }
    }
}
