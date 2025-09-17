using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empezando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Datos del producto y del cliente

            double descuento = 0;

            string tipoDecliente = "", porcenDes = "";

            Console.WriteLine("====================================");
            Console.WriteLine("       SISTEMA DE FACTURACION       ");
            Console.WriteLine("====================================");
            Console.WriteLine("Ingrese el nombre del producto que desea comprar: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el precio del producto: S/ ");
            double precioB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("tipo de cliente (1=Frecuente, 2=Nuevo, 3=Corporativo)");
            int Tcliente = Convert.ToInt32(Console.ReadLine());
            switch (Tcliente)
            {

                case 1:

                    descuento = 0.10;

                    tipoDecliente = "Frecuente";

                    porcenDes = "10%";

                    break;

                case 2:

                    descuento = 0.00;

                    tipoDecliente = "Nuevo";

                    porcenDes = "0%";

                    break;

                case 3:

                    descuento = 0.15;

                    tipoDecliente = "Corporativo";

                    porcenDes = "15%";

                    break;

                default:

                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Cliente no valido ERROR ");

                    Console.ResetColor();

                    return;
                }


            //calculos del producto

            double montoDesc = precioB * descuento;

            double precioConDes = precioB - montoDesc;

            double IGV = precioConDes * 0.18;

            double precioFinal = precioConDes + IGV;

            //Resultados finales del producto

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("====================================");
            Console.WriteLine("              FACTURA               ");
            Console.WriteLine("====================================");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Producto: {nombre}");
            Console.WriteLine($"Cliente: {tipoDecliente} (Descuento: {porcenDes})");
            Console.ResetColor();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Precio base: S/. {precioB:F2}");
            Console.WriteLine($"Descuento aplicado: S/. {montoDesc: F2}");
            Console.WriteLine($"IGV (18%): S/. {IGV:F2}");
            Console.WriteLine($"Precio final: S/. {precioFinal:F2}");
            Console.ResetColor();

        }
    }
}
