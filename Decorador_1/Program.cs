using System;

namespace Decorador_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos el componente central con tipo IComponente
            // para permitir la decoracion

            IComponente miAuto = new Auto("2022", "4 puertas", 20000);

            Console.WriteLine(miAuto);

            // Si necesitamos usar un metodo propio de Auto
            // necesitamos hacer uso de un type cast
            ((Auto)miAuto).Puertas(true);

            Console.WriteLine("-----------");

            // Decoramos el auto con un sistema de sonido
            miAuto = new SistemaSonido(miAuto);

            //comprobamos la adicion de las caracteristicas
            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);

            Console.WriteLine("-----------");

            // Decoramos con nitrogeno
            miAuto = new Nitrogeno(miAuto);

            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);

            // para usar algo propio de Nitrogeno necesitamos TypeCast
            ((Nitrogeno)miAuto).UsaNitrogeno();

            Console.WriteLine("-----------");

            // No podemos usar los metodos especificos una vez que
            // decoramos sobre ella

            //((Auto)miAuto).Puertas();//Da error
        }
    }
}
