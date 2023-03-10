using System;
using System.IO;

namespace Destructores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManejoArchivos miarchivo = new ManejoArchivos();
            miarchivo.Mensaje();
            Console.ReadKey();
        }
        
    }
}
