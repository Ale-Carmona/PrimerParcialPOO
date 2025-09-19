using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialPOO
{
    internal class ExportatExcel
    {
        private List<Celular> lista = new List<Celular>();
        Celular c = new Celular();

        public void ExportarExcel()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Celulares");
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Celulares.xlsx";
                // Encabezados
                worksheet.Cell(1, 1).Value = "Marca";
                worksheet.Cell(1, 2).Value = "Modelo";
                worksheet.Cell(1, 3).Value = "Alamcenamiento";
                worksheet.Cell(1, 4).Value = "RAM";
                worksheet.Cell(1, 5).Value = "Precio";

                // Datos
                for (int i = 0; i < lista.Count; i++)
                {
                    worksheet.Cell(i + 2, 1).Value = lista[i].Marca;
                    worksheet.Cell(i + 2, 2).Value = lista[i].Modelo;
                    worksheet.Cell(i + 2, 3).Value = lista[i].Alamcenamiento;
                    worksheet.Cell(i + 2, 4).Value = lista[i].RAM;
                    worksheet.Cell(i + 2, 5).Value = lista[i].Precio;
                }

                workbook.SaveAs(ruta);

                Console.WriteLine("guardado con exito");
            }
        }
    }
}