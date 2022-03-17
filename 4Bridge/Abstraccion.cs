using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Bridge
{
    //Esta clase conecta al cliente con la abstraccion a utilizar
    class Abstraccion
    {
        //Referencia a la implementacion
        IBridge implementacion;
        Dictionary<string, double> productos;

        //Metodo 1, el mas usual
        //Constructor, recibimos la implementacion concreta
        public Abstraccion(IBridge implementacion, Dictionary<string, double> productos)
        {
            this.implementacion = implementacion;
            this.productos = productos;
        }

        //Metodo 2, cuidado no deseamos hacer una fabrica
        public Abstraccion(int tipo, Dictionary<string, double> producto)
        {
            if (tipo == 1)
                implementacion = new Implementacion1();
            if (tipo == 2)
                implementacion = new Implementacion2();
            if (tipo == 3)
                implementacion = new Implementacion3();

            productos = producto;
        }

        // Estos metodos representan la interfaz que conoce el cliente
        public void MostrarTotales()
        {
            implementacion.MostrarTotales(productos);
        }
        public void Listar()
        {
            implementacion.ListarProductos(productos);
        }
    }
}
