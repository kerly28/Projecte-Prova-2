using System;
using Prova;
namespace Exericici2
{
    public class Program
    {
        public static void Main()
        {
            //inici constants
            const string KeySearch = "Introdueix quin valor vols buscar:";
            const string Position = "El teu número esta en la posició";

            int[] arr = { 10, -4, 6, 4, 8, 13, 2, -4 };

            //primer ordenm l'array
            FirstSort.Order(arr, 0, arr.Length - 1);

            //Indiquem quin valor volem buscar
            Console.WriteLine(KeySearch);
            int key = Convert.ToInt32(Console.ReadLine());
            int result = FirstSort.BinarySearch(arr, 0, arr.Length - 1, key);

            //Mostrem l'array ordenat
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            try
            {
                if (result == -1)
                {
                    Console.WriteLine("El teu número no esta en l'array");
                }
                else
                {
                    Console.WriteLine(Position + " " + result);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

    }
}
