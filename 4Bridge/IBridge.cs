using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Bridge
{
    interface IBridge
    {
        void MostrarTotales(Dictionary<string, double> productos);
        void ListarProductos(Dictionary<string, double> productos);

    }
}
