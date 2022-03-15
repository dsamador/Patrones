using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador_1
{
    class SistemaSonido : IComponente
    {
        private IComponente decoramosA;

        public SistemaSonido(IComponente componente)
        {
            decoramosA = componente;
        }

        public override string ToString()
        {
            return $"Radio Van and Amador {decoramosA.ToString()}";
        }
        
        public double Costo()
        {
            return decoramosA.Costo() + 3500;
        }

        public string Funciona()
        {
            return decoramosA.Funciona() + ", Enciendo el radio";
        }        
    }
}
