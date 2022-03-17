using System;
using System.Collections.Generic;

namespace _4Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Main representa al cliente
            Dictionary<string, double> productos = new Dictionary<string, double>();

            //productos
            productos.Add("M101", 56.32);
            productos.Add("M234", 23.88);
            productos.Add("C654", 974.56);
            productos.Add("M401", 43.28);
            productos.Add("C345", 785.12);
            productos.Add("D567", 432.56);
            productos.Add("M103", 874.54);
            productos.Add("D901", 23.18);
            productos.Add("C732", 43.12);
            productos.Add("M056", 21.42);

            //Creamos el bridge
            //Abstraccion bridge = new Abstraccion(new Implementacion3(), productos);            

            
            while (true)
            {
                Console.WriteLine("Digita el numero de la version");
                int version = Int16.Parse(Console.ReadLine());

                Abstraccion bridge = new Abstraccion(version, productos);

                bridge.MostrarTotales();//Esto no debe cambiar
                bridge.Listar();//Esto tampoco
            }            
        }
    }
}
