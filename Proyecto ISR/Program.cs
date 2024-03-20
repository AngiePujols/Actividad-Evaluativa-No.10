using Proyecto_ISR.Controller;
using System;

namespace Proyecto_ISR
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menuActivo = true;

            CalculoController controller = new CalculoController();

            while (menuActivo)
            {
                Console.Clear();
                Console.WriteLine("Bienvenido al Calculo del ISR");
                Console.WriteLine("\n\nFavor ingresar su sueldo mensual: ");

                string entrada = Console.ReadLine() ?? "";

                if (decimal.TryParse(entrada, out decimal sueldoActual))
                {
                    decimal isrPagar = 0;

                    short opcionEvaluacion = controller.evaluarSueldo(sueldoActual);

                    switch (opcionEvaluacion)
                    {
                        case 1: //Exento
                            break;
                        case 2: //15%
                            isrPagar = controller.evaluarSueldo15(sueldoActual);
                            break;
                        case 3: //20%
                            isrPagar = controller.evaluarSueldo20(sueldoActual);
                            break;
                        case 4: //25%
                            isrPagar = controller.evaluarSueldo25(sueldoActual);
                            break;
                        default:
                            isrPagar = 0;
                            break;
                    }

                    Console.WriteLine($"El ISR a pagar es de {isrPagar:N} mensual");
                }
                else
                {
                    Console.WriteLine("Favor ingresar solo valores numericos");
                }
                Console.ReadKey();
            }
        }
    }
}