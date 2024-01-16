using System.Xml.Linq;

namespace Ejercicio8ArrayC
{
    class Program
    {
        static void Main(string[] args)
        {
            //INDEXOF
            string[] palabras = { "Hola", "Adiós", "Nuevo", "Viejo", "Vamos" };
            string ele = "Adiós";
            int indice = Array.IndexOf(palabras, ele);
            bool continuar = false;

            if (indice >= 0)
            {
                Console.WriteLine($"Elemento {ele} encontrado en el índice: {indice}");
            }
            else
            {
                Console.WriteLine($"Elemento {ele} no encontrado.");
            }
            
            
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------");
            
            
            do {Console.WriteLine("escribe la palabra");
            string palusu = Console.ReadLine(); 
            int ind =Array.IndexOf(palabras, palusu);
            if (ind >= 0) 
            {
                Console.WriteLine($"Elemento {palusu} encontrado en el índice: {indice}");
            }
            else
            {
                Console.WriteLine($"Elemento  {palusu} no encontrado.");
            }
            Console.WriteLine("1. continuar , 2. para terminar");
               int seguir = Convert.ToInt32( Console.ReadLine());
                if (seguir == 1)
                {
                    continuar = false;
                }
                else { continuar = true; }
            }
            while (!continuar);

            //WHERE - filtrar
            int[] numeros = { 1, 5, 7, 8, 4, 3, 9 };
            var celdasSi =  numeros.Where(numeros=>numeros>3);
            foreach(int numero in celdasSi)
            {
                Console.WriteLine(celdasSi);
            }
           
        }
    }
}