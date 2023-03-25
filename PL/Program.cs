using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Program
    {
        static void Main(string[] args)
        {
            string n;

            Console.WriteLine("Ingrese un Digito:");
            n = Console.ReadLine();

            int suma = 0, suma1 = 0, suma2 = 0;

            foreach (char digito in n) //Separa los numeros Ingresados
            {
                suma += int.Parse(digito.ToString());
            }

            if (suma > 9) //Verifica si es la suma mayor a 9 VALORES DE 2 a 4 NUMEROS
            {
                foreach (char dig in suma.ToString()) //repite el proceso pero con el valor de suma
                {
                    suma1 += int.Parse(dig.ToString()); //se separan con una nueva variable suma1
                }

            }
            else
            {
                Console.WriteLine("El Super Digito de: " + n + " es: " + suma);
                Console.ReadKey();
            }

            Console.WriteLine("El Super Digito de: " + n + " es: " + suma1); //da el resultado si es que entra en el if
            Console.ReadKey();
        }
    }
}