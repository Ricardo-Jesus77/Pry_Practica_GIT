using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pry_Practica_GIT
{
    public abstract class Boleto
    {
        public double PrecioBase { get; set; }

        public Boleto(double precioBase)
        {
            PrecioBase = precioBase;
        }

        public abstract double CalcularPrecioFinal();
    }
}
