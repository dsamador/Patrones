using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Bridge
{
    class Implementacion1 : IBridge
    {
        public void MostrarTotales(Dictionary<string, double> productos)
        {
            double total = 0;
            int cantidad = 0;

            foreach (KeyValuePair<string, double> p in productos)
            {
                total += p.Value;
                cantidad++;
            }
            Console.WriteLine($"El total de {cantidad}, es ${total}");
        }

        public void ListarProductos(Dictionary<string, double> productos)
        {
            foreach (KeyValuePair<string, double> p in productos)
            {
                Console.WriteLine(p.Key);
            }
        }
    }
}
