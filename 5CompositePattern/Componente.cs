using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5CompositePattern
{
    public class Componente<T> : IComponente<T>
    {
        //Identificador del componente
        public T Nombre {  get; set; }

        public Componente(T nombre)
        {
            Nombre = nombre;
        }

        public void Adicionar(IComponente<T> elemento)
        {
            Console.WriteLine("Solo se adiciona a los compuestos no a los componentes");
        }
        
        public IComponente<T> Borrar(T elemento)
        {
            Console.WriteLine("No se puede eliminar directamente");
            //retornamos al mismo componente que tenemos
            return this;
        }
    }
}
