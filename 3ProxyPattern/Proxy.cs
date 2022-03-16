using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ProxyPattern
{
    //Haremos uso de anidamiento dentro de la clase
    //Esto hace que cualquier clase colocada como privada y anidada
    //solo sea conocida por Proxy
    public class Proxy
    {
        public interface ISujeto
        {
            void Peticion(int opcion);
        }

        public class ProxySencillo : ISujeto
        {
            private Cocina cocina;            

            public void Peticion(int opcion)
            {
                if(cocina == null)
                {
                    Console.WriteLine("Activando el sujeto");
                    cocina = new Cocina();
                }
                if (opcion == 1)
                    cocina.RecetaSecreta();
                if (opcion == 2)
                    cocina.Cocinar(5);
            }
        }

        public class ProxySeguro : ISujeto
        {
            private Cocina cocina;

            public void Peticion(int opcion)
            {
                string password;

                Console.WriteLine("Dame el password");
                password = Console.ReadLine();

                if(password == "abc123")
                {
                    if(cocina == null)
                    {
                        Console.WriteLine("Activando el sujeto");
                        cocina = new Cocina();
                    }
                    if (opcion == 1)
                        cocina.RecetaSecreta();
                    if (opcion == 2)
                        cocina.Cocinar(5);
                }
                else
                {
                    Console.WriteLine("Acceso denegado");
                }
            }
        }

        private class Cocina
        {
            public void RecetaSecreta()
            {
                Console.WriteLine("Pan");
                Console.WriteLine("Aceite de oliva");
                Console.WriteLine("Especias");
                Console.WriteLine("Jamon");
                Console.WriteLine("Queso");
            }
            public void Cocinar(int n)
            {
                Console.WriteLine($"Cocinando {n} recetas");
            }
        }
    }
}
