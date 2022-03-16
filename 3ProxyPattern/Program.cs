using System;

namespace _3ProxyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Proxy.ISujeto miProxy = new Proxy.ProxySencillo();

            
            miProxy.Peticion(1);
            Console.WriteLine("------------");
            miProxy.Peticion(2);
            Console.WriteLine("------------");

            Proxy.ISujeto miProxySeguro = new Proxy.ProxySeguro();

            miProxySeguro.Peticion(1);
            Console.WriteLine("------------");
            miProxySeguro.Peticion(2);
            
        }
    }
}
