using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pry_Practica_GIT
{
    public class BoletoAdultoMayor : Boleto
    { 
        public string NumInapam {  get; set; }

        public BoletoAdultoMayor(double precioBase,string credencial) : base(precioBase)
        {
            NumInapam = credencial;
        }
       

        public override double CalcularPrecioFinal()
        {
            return PrecioBase * 0.50;
        }

    }
}
