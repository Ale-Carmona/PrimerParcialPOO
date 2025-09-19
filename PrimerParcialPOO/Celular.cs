using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialPOO
{
    internal class Celular
    {
        public Celular(string marca, string modelo, int alamcenamiento, int rAM, double precio)
        {
            Marca = marca;
            Modelo = modelo;
            Alamcenamiento = alamcenamiento;
            RAM = rAM;
            Precio = precio;
        }

        public Celular() { }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Alamcenamiento { get; set; }
        public int RAM { get; set; }
        public double Precio { get; set; }
    }
}
