using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            int extension;
            int cantidad;
            string resumen;

            Mapa mapaUno = new Mapa("HOla", "Pepe", 1996, "1646", "123456", 45, 12);
            Mapa mapaDos = new Mapa("HOla", "Pepe", 1996, "1646", "123456", 45, 12);
            Libro libroUno = new Libro("HOla", "Pepe", 1996, "1646", "123456", 45);

            Escaner escanerUno = new Escaner("HP", Escaner.TipoDoc.mapa);

            bool agregarDocumento = escanerUno + mapaUno;
            bool agregarDocumentoDos = escanerUno + libroUno;


            Informes.MostrarDistribuidos(escanerUno, out extension, out cantidad, out resumen);

            Console.WriteLine($"Extension: {extension}");
            Console.WriteLine($"Cantidad: {cantidad}");
            Console.WriteLine();
            Console.WriteLine($"Resumen:\n{resumen}");





  




            Console.ReadKey();
        }
    }
}
