using System;
using Prova;

//PRE:L'usuari introdueix 3 numeros (dia, mes i any)
namespace Exercici3
{
    public class Program
    {
        public static void Main()
        {
            //constants de missatges
            const string InputDay = "Introdueix el dia: ";
            const string InputMonth = "Introdueix el mes: ";
            const string InputYear = "Introdueix l'any: ";
            const string Validate= "La data introduida és vàlida";
            const string NotValidate = "La data introduida no és vàlida";

            //demanen a l'usuari que introdueixi el dia, mes i any
            Console.Write(InputDay);
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write(InputMonth);
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write(InputYear);
            int year = Convert.ToInt32(Console.ReadLine());

            //es criden els mètodes per validar el dia, mes i any
            bool dayValid = ExerciciTres.Day(day);
            bool monthValid = ExerciciTres.Month(month);
            bool yearValid = ExerciciTres.YearValidate(year);
            if (dayValid && monthValid && yearValid)
            {
                Console.WriteLine(Validate);
            }
            else
            {
                Console.WriteLine(NotValidate);
            }
        }
    }
}
//POST:Es retorna si la data està dins el rang o no