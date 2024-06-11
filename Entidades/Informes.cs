using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Informes
    {

        //Metodos

        /*
         * La logica que pregunta por cada uno de los estados y agrega la informacion se hace en el metodo general, luego cadauno en particular llama al general con las variables
         * correspondientes para que funcione como es esperado del metodo.
         */
        public static void MostrarDistribuidos(Escaner escaner, out int extension, out int cantidad, out string resumen)
        {
            MostrarDocumentosPorEstado(escaner, Documento.Paso.Distribuido, out extension, out cantidad, out resumen);

        }
        public static void MostrarEnEscaner(Escaner escaner, out int extension, out int cantidad, out string resumen)
        {
            MostrarDocumentosPorEstado(escaner, Documento.Paso.EnEscaner, out extension, out cantidad, out resumen);

        }

        public static void MostrarEnRevision(Escaner escaner, out int extension, out int cantidad, out string resumen)
        {
            MostrarDocumentosPorEstado(escaner, Documento.Paso.EnRevision, out extension, out cantidad, out resumen);

        }

        public static void MostrarTerminados(Escaner escaner, out int extension, out int cantidad, out string resumen)
        {
            MostrarDocumentosPorEstado(escaner, Documento.Paso.Terminado, out extension, out cantidad, out resumen);
        }




        public static void MostrarDocumentosPorEstado(Escaner e, Documento.Paso estado, out int extension, out int cantidad, out string resumen)
        {

            extension = 0;
            cantidad = 0;
            resumen = "";
            StringBuilder sb = new StringBuilder();

            foreach (Documento doc in e.ListaDocumentos)
            {
                if (doc.Estado == estado)
                {
                    if (doc is Libro libro)
                    {
                        extension += libro.NumPaginas;
                    }
                    else if (doc is Mapa mapa)
                    {
                        extension += mapa.Superficie;
                    }

                    cantidad++;
                    sb.Append(doc.ToString().ToString());
                }
            }
            resumen = sb.ToString();
        }

    }

}










