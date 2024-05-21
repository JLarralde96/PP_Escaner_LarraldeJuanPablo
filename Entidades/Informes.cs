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

        static void MostrarDocumentosPorEstado(Escaner escaner, Documento.Paso estado, out int extension, out int cantidad, out string resumen)
        {
            cantidad = 0;
            extension = 0;
            resumen = "";
            StringBuilder sb = new StringBuilder();


            foreach (Documento doc in escaner.ListaDocumentos)
            {
                if (doc.Estado == Documento.Paso.Distribuido)
                {
                    if (escaner.Tipo == Escaner.TipoDoc.mapa)
                    {
                        if (doc is Mapa mapa)
                        {
                            cantidad += 1;
                            extension += mapa.Superficie;
                            sb.AppendLine(mapa.ToString());
                        }
                    }
                    if (escaner.Tipo == Escaner.TipoDoc.libro)
                    {
                        if (doc is Libro libro)
                        {
                            cantidad += 1;
                            extension += libro.NumPaginas;
                            sb.AppendLine(libro.ToString());
                        }
                    }
                }
                else if (doc.Estado == Documento.Paso.EnEscaner)
                {
                    if (escaner.Tipo == Escaner.TipoDoc.mapa)
                    {
                        if (doc is Mapa mapa)
                        {
                            cantidad += 1;
                            extension += mapa.Superficie;
                            sb.AppendLine(mapa.ToString());
                        }
                    }
                    if (escaner.Tipo == Escaner.TipoDoc.libro)
                    {
                        if (doc is Libro libro)
                        {
                            cantidad += 1;
                            extension += libro.NumPaginas;
                            sb.AppendLine(libro.ToString());
                        }
                    }
                }
                else if (doc.Estado == Documento.Paso.EnRevision)
                {
                    if (escaner.Tipo == Escaner.TipoDoc.mapa)
                    {
                        if (doc is Mapa mapa)
                        {
                            cantidad += 1;
                            extension += mapa.Superficie;
                            sb.AppendLine(mapa.ToString());
                        }
                    }
                    if (escaner.Tipo == Escaner.TipoDoc.libro)
                    {
                        if (doc is Libro libro)
                        {
                            cantidad += 1;
                            extension += libro.NumPaginas;
                            sb.AppendLine(libro.ToString());
                        }
                    }
                }
                else if (doc.Estado == Documento.Paso.Terminado)
                {
                    if (escaner.Tipo == Escaner.TipoDoc.mapa)
                    {
                        if (doc is Mapa mapa)
                        {
                            cantidad += 1;
                            extension += mapa.Superficie;
                            sb.AppendLine(mapa.ToString());
                        }
                    }
                    if (escaner.Tipo == Escaner.TipoDoc.libro)
                    {
                        if (doc is Libro libro)
                        {
                            cantidad += 1;
                            extension += libro.NumPaginas;
                            sb.AppendLine(libro.ToString());
                        }
                    }
                }
            }

            resumen = sb.ToString();


        }



    }





}
