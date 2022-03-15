using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador_1
{
    //Esta clase representa al componente y debe de implementar
    //a IComponente para poder llevar a cabo la decoracion
    public class Auto : IComponente
    {
        private string modelo;
        private string caracteristicas;
        public double costo;

        public Auto(string modelo, string caracteristicas, double costo)
        {
            this.modelo = modelo;
            this.caracteristicas = caracteristicas;
            this.costo = costo;
        }

        public void Puertas(bool estado)
        {
            if(estado)
                Console.WriteLine("Puertas cerradas");
            else
                Console.WriteLine("Puertas abiertas");
        }

        public override string ToString()
        {
            return $"Modelo {modelo}, {caracteristicas} \r\n";
        }

        public double Costo()
        {
            return costo;
        }

        public string Funciona()
        {
            return "Encendi el motor";
        }
    }
}
