using System;

namespace Decorador_1
{
    class Nitrogeno : IComponente
    {
        // Variable de referencia hacia quien decoramos
        private IComponente decoramosA;

        // Pasamos al objeto que va a ser decorado
        public Nitrogeno(IComponente componente)
        {
            decoramosA = componente;
        }

        public override string ToString()
        {
            return $"Sistema de Nitrogeno\r\n {decoramosA.ToString()}";
        }

        public double Costo()
        {
            //el costo de lo que decoro mas mi costo como componente
            return decoramosA.Costo() + 45000;
        }

        public string Funciona()
        {
            return $"{decoramosA.Funciona()}, Nitrogeno listo";
        }

        public void UsaNitrogeno()
        {
            Console.WriteLine("Nitrogeno en uso");
        }
    }
}