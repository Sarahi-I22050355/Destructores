using System;
using System.IO;


namespace Destructores
{
    internal class ManejoArchivos
    {
        StreamReader archivo = null;

        int contador = 0;

        string linea;

        public ManejoArchivos() 
        {
            archivo = new StreamReader(@"C:\Users\Sarah\OneDrive\Escritorio\data.txt");
            while ((linea = archivo.ReadLine())!=null)
            {
                Console.WriteLine(linea);
                contador++;
            }
        }
        public void Mensaje()
        {
            Console.WriteLine("Hay {0} lineas",contador);

        }
        //El codigo interno de un destructor es para que se ejecute inmediatamnte
        //despues de aver eliminado el recolector de basura el recurso correspondiente
        ~ManejoArchivos()
        {
            archivo.Close();
        }
    }
}
