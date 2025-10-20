namespace RevisionDeCodigoPila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el código a revisar:");
            string cadena = Console.ReadLine();

            PilaRevision pilaRevision = new PilaRevision();
            bool error = false;

            foreach (char x in cadena)
            {
                if (x == ')' || x == ']' || x == '}')
                {
                    if (pilaRevision.EstaVacia())
                    {
                        error = true;
                        break;
                    }
                    else if (!pilaRevision.Comparar(x))
                    {
                        error = true;
                        break;
                    }
                    else
                    {
                        pilaRevision.Eliminar();
                    }
                }
                else if (x == '(' || x == '[' || x == '{')
                {
                    pilaRevision.Insertar(x);
                }
            }

            if (!error && pilaRevision.EstaVacia())
                Console.WriteLine("El código está correcto.");
            else
                Console.WriteLine("Error: las llaves, paréntesis o corchetes están mal ubicados.");

            Console.ReadKey();
        }
    }
}
