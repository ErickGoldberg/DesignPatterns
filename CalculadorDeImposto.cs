using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class CalculadorDeImposto
    {
        public double CalculadorImposto(Orcamento orcamento, IImposto imposto)
        {
            return imposto.Calcular(orcamento);
        }
    }
}
