using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador_1
{
    //Interfaz para la decoracion
    public interface IComponente
    {
        double Costo();
        string Funciona();
    }
}
