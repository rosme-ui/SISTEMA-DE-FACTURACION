using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo_T1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Datos del producto y del cliente
            double precioFinal, IGV, precioConDes, montoDesc, precioB, descuento = 0;
            int Tcliente;
            string nombre, tipoDecliente = "", porcenDes = "";

            Console.WriteLine("====================================");
            Console.WriteLine("       SISTEMA DE FACTURACION       ");
            Console.WriteLine("====================================");
            Console.WriteLine("Ingrese el nombre del producto que desea comprar: ");
            nombre = Console.ReadLine();
            //Valida que el nombre ingresado esté escrito de manera correcta 
            if (nombre == ""||!nombre.Any(char.IsLetter))
            {
                Console.WriteLine("ERROR!");
                return;
            }
            Console.WriteLine("Ingrese el precio del producto: S/ ");
            precioB = double.Parse(Console.ReadLine());
            //Valida que el precio ingresado sea el correcto
            if (precioB<=0)
            {
                Console.WriteLine("ERROR!");
                return;
            }
            Console.WriteLine("tipo de cliente (1=Frecuente, 2=Nuevo, 3=Corporativo)");
            Tcliente = int.Parse(Console.ReadLine());
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
                    Console.WriteLine("Cliente no valido ERROR ");
                    return;
            }

            //calculos del producto
            montoDesc = precioB * descuento;
            precioConDes = precioB - montoDesc;
            IGV = precioConDes * 0.18;
            precioFinal = precioConDes + IGV;

            //Resultados finales del producto
            Console.WriteLine("====================================");
            Console.WriteLine("              FACTURA               ");
            Console.WriteLine("====================================");
            Console.WriteLine($"Producto: {nombre}");
            Console.WriteLine($"Cliente: {tipoDecliente} (Descuento Aplicado: {porcenDes})");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Precio base: S/. {precioB.ToString("F2")}");
            Console.WriteLine($"Precio con descuento: S/. {precioConDes.ToString("F2")}");
            Console.WriteLine($"IGV (18%): S/. {IGV.ToString("F2")}");
            Console.WriteLine($"Precio final: S/. {precioFinal.ToString("F2")}");

            Console.ReadKey();
        }
    }
}
