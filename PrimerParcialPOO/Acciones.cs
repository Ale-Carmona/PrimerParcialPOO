using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialPOO
{
    internal class Acciones
    {
        private List<Celular> lista=new List<Celular>();
        Celular c= new Celular();

        public void Agregar()
        {
            Console.WriteLine("cuantos celulares deceas agregar?");
            int num=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("ingresa marca");
                c.Marca=Console.ReadLine();

                Console.WriteLine("ingresa modelo");
                c.Modelo = Console.ReadLine();

                Console.WriteLine("ingresa almacenamiento");
                c.Alamcenamiento = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("ingresa RAM");
                c.RAM = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("ingresa precio");
                c.Precio =Convert.ToDouble(Console.ReadLine());

                lista.Add(new Celular(c.Marca, c.Modelo, c.Alamcenamiento, c.RAM, c.Precio));

            }
        }

        public void Mostrar()
        {
            foreach (var ce in lista)
            {
                Console.WriteLine($"Marca: {ce.Marca}");
                Console.WriteLine($"Modelo: {ce.Modelo}");
                Console.WriteLine($"Almacenamiento: {ce.Alamcenamiento}");
                Console.WriteLine($"Ram: {ce.RAM}");
                Console.WriteLine($"Precio: {ce.Precio}");
            }
        }


        public void Actualizar()
        {
            Console.WriteLine("ingresa marca para actualizar");
            string marcaactualizar=Console.ReadLine();
            Celular Actualizar= lista.FirstOrDefault(a => a.Marca.ToLower() == marcaactualizar.ToLower());


            if( Actualizar != null )
            {
                Console.WriteLine("ingresa Marca");
                Actualizar.Marca = Console.ReadLine();

                Console.WriteLine("ingrese nuevo Modelo");
                Actualizar.Modelo = Console.ReadLine();

                Console.WriteLine("ingrese nuevo Almacenamiento");
                Actualizar.Alamcenamiento = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("ingrese nueva ram");
                Actualizar.RAM = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("ingrese nuevo precio");
                Actualizar.Precio = Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("no se encontro la marca");
            }

        }

        public void Eliminar()
        {
            Console.WriteLine("ingrese la marca a eliminar");
            string eliminar=Console.ReadLine();
            Celular marcaeliminar = lista.FirstOrDefault(a => a.Marca.ToLower() == eliminar.ToLower());

            if ( marcaeliminar != null )
            {
                lista.Remove(marcaeliminar);
                Console.WriteLine("marca eliminado");
            }
            else
            {
                Console.WriteLine("no se encontro esa marca");
            }
        }
    }
}
