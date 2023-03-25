using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BL
{
    public class SuperDigito
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.SuperDigitoContext context = new DL.SuperDigitoContext())
                {
                    var query = context.Historials.FromSqlRaw("HistorialGetAll").ToList();

                    if (query != null)
                    {
                        result.Objects = new List<object>();

                        foreach (var obj in query)
                        {
                            ML.SuperDigito superDigito = new ML.SuperDigito();

                            superDigito.idHistorial = obj.IdHistorial;
                            superDigito.Numero = obj.Numero;
                            superDigito.Resultado = obj.Resultado;
                            superDigito.FechaHora = obj.FechaHora.ToString();

                            result.Objects.Add(superDigito);
                        }
                    }
                }
                result.Correct = true;
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.Message = ex.Message;
            }
            return result;
        }

        public static ML.Result CalcularSDigito(ML.SuperDigito superDigito)
        {
            ML.Result result = new ML.Result();

            int suma = 0, suma1 = 0;

            foreach (char digito in superDigito.Numero) //Separa los numeros Ingresados
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


            return result;
        }
    }
}