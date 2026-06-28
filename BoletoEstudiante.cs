using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Pry_Practica_GIT
{

    public class BoletoEstudiante : Boleto
    {
        public string Matricula { get; set; }

        public BoletoEstudiante(double precioBase, string matricula)
            : base(precioBase)
        {
            Matricula = matricula;
        }

        public override double CalcularPrecioFinal()
        {
            return PrecioBase * 0.70;
        }
    }

}

