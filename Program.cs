using System;
using Prova;

//PRE:L'usuari introdueix 20 valors enters i quin valor vol buscar dins l'array
namespace Exercici5
{
    public class Program
    {
        public static void Main()
        {
            const string Msg = "Introdueix 20 valors enters: ";
            const string SearchNum = "Introdueix el valor que vols buscar: ";
            const string Position = "El valor que vols buscar està a la posició: ";
            const string NotFound = "El valor que vols buscar no està a l'array";

            int[] array = new int[20];
            Console.WriteLine(Msg);
            int i;
            //demanem a l'usari que introdueixi 20 valors enters
            for (i = 0; i < 20; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            //ordenem l'array introduit i mostrem l'array ordenat per pantalla
            ExerciciCinc.Order(array, 0, 19);
            Console.WriteLine("L'array ordenat és: ");
            for (i = 0; i < 20; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine(SearchNum);
            int key = Convert.ToInt32(Console.ReadLine());
            //busquem el valor introduit per l'usuari dins l'array
            ExerciciCinc.Order(array, 0, 19);
            int pos = Array.BinarySearch(array, key);
            if (pos >= 0)
            {
                Console.WriteLine(Position + pos);
            }
            else
            {
                Console.WriteLine(NotFound);


            }
        }
    }
}
//POST:El programa mostra la llista ordenada ascendentment i si el valor que vol buscar estar dins l'array