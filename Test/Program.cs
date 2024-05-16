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

            Mapa mapaUno = new Mapa(1645, "Vallejos", "123456","Nuevo Continente", 20, 20);
            Mapa mapaDos = new Mapa(1645, "Colon", "852963","Portugal", 12, 23);

            Escaner escanerUno = new Escaner("HP", Escaner.TipoDoc.mapa);

            bool agregarDocumento = escanerUno + mapaUno;
            bool agregarDocumentoDos = escanerUno + mapaDos;


            Informes.MostrarDistribuidos(escanerUno, out extension, out cantidad, out resumen);

            Console.WriteLine($"Extension: {extension}");
            Console.WriteLine($"Cantidad: {cantidad}");
            Console.WriteLine($"Resumen:\n{resumen}");



            Console.ReadKey();
        }
    }
}
