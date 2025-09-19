using DocumentFormat.OpenXml.Office.CustomUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Acciones a = new Acciones();
            ExportatExcel export = new ExportatExcel();

            while (true)
            {
                switch (Menu())
                {
                    case 1:
                        a.Agregar();
                        break;
                    case 2:
                        a.Mostrar();
                        break;
                    case 3:
                        a.Actualizar();
                        break;
                    case 4:
                        a.Eliminar();
                        break;
                    case 5:
                        export.ExportarExcel();
                        break;

                    default:
                        break;

                }
            }
        }
        static int Menu()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("1)agregar");
            Console.WriteLine("2)Mostrar");
            Console.WriteLine("3)Actualizar");
            Console.WriteLine("4)Eliminar");
            Console.WriteLine("5)Exportar a Excel");
            Console.WriteLine("-------------------------------------------");

            int opc = Convert.ToInt32(Console.ReadLine());
            return opc;

        }
    }
}
