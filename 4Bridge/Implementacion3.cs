using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Bridge
{
    class Implementacion3 : IBridge
    {       
        public void MostrarTotales(Dictionary<string, double> productos)
        {
            double total = 0;
            double totalm = 0;
            double totalc = 0;
            double totald = 0;
            int cantidad = 0;

            foreach (KeyValuePair<string, double> p in productos)
            {
                total += p.Value;
                if (p.Key[0] == 'C')
                    totalc += p.Value;
                if (p.Key[0] == 'M')
                    totalm += p.Value;
                if (p.Key[0] == 'D')
                    totald += p.Value;

                cantidad++;
            }

            Console.WriteLine($"El total de comida es ${totalc}, {totalc / total * 100}% del total");
            Console.WriteLine($"El total de medicamentos es ${totalm}, {totalm / total * 100}% del total");
            Console.WriteLine($"El total de deportes es ${totald}, {totald / total * 100}% del total");

            Console.WriteLine($"El total de {cantidad} es ${total}");
        }
        public void ListarProductos(Dictionary<string, double> productos)
        {
            foreach (KeyValuePair<string, double> p in productos)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                if (p.Key[0] == 'C')
                    Console.WriteLine($"{p.Key} - {p.Value}");               
            }
            foreach (KeyValuePair<string, double> p in productos)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (p.Key[0] == 'M')
                    Console.WriteLine($"{p.Key} - {p.Value}");               
            }
            foreach (KeyValuePair<string, double> p in productos)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                if (p.Key[0] == 'D')
                    Console.WriteLine($"{p.Key} - {p.Value}");               
            }
        }
    }
}
