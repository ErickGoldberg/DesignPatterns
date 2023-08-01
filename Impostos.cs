using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class ICMS : IImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05 + 50;
        }
    }

    public class ISS : IImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }

    public class ICCC : IImposto
    {
        public double Calcular(Orcamento orcamento) 
        {
            double iccc;
            if(orcamento.Valor < 1000)
            {
                iccc =  orcamento.Valor * 0.05;
            }
            else if(orcamento.Valor >= 1000 && orcamento.Valor <= 3000)
            {
                iccc = orcamento.Valor * 0.07;
            }
            else
            {
                iccc = orcamento.Valor * 0.08 + 30;
            }
            return iccc;
        }
    }
}
 