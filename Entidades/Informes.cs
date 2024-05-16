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

        public static void MostrarDistribuidos(Escaner escaner, out int extension, out int cantidad, out string resumen)
        {
            cantidad = 0;
            extension = 0;
            resumen = "";
            StringBuilder sb = new StringBuilder();


            foreach (Documento doc in escaner.ListaDocumentos)
            {
                if (escaner.Tipo == Escaner.TipoDoc.mapa)
                {
                    if (doc.Estado == Documento.Paso.Distribuido)
                    {
                        if (doc is Mapa mapa)
                        {
                            cantidad += 1;
                            extension += mapa.Superficie;
                            sb.AppendLine(mapa.ToString());
                        }
                    }
                }

                if (escaner.Tipo == Escaner.TipoDoc.libro)
                {
                    if (doc.Estado == Documento.Paso.Distribuido)
                        if (doc is Libro libro)
                        {
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
        public static void MostrarEnEscaner(Escaner escaner, out int extension, out int cantidad, out string resumen)
        {
            cantidad = 0;
            extension = 0;
            resumen = "";
            StringBuilder sb = new StringBuilder();


            foreach (Documento doc in escaner.ListaDocumentos)
            {
                if (escaner.Tipo == Escaner.TipoDoc.mapa)
                {
                    if (doc.Estado == Documento.Paso.EnEscaner)
                    {
                        if (doc is Mapa mapa)
                        {
                            cantidad += 1;
                            extension += mapa.Superficie;
                            sb.AppendLine(mapa.ToString());
                        }
                    }
                }

                if (escaner.Tipo == Escaner.TipoDoc.libro)
                {
                    if (doc.Estado == Documento.Paso.EnEscaner)
                        if (doc is Libro libro)
                        {
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

        public static void MostrarEnRevision(Escaner escaner, out int extension, out int cantidad, out string resumen)
        {
            cantidad = 0;
            extension = 0;
            resumen = "";
            StringBuilder sb = new StringBuilder();


            foreach (Documento doc in escaner.ListaDocumentos)
            {
                if (escaner.Tipo == Escaner.TipoDoc.mapa)
                {
                    if (doc.Estado == Documento.Paso.EnRevision)
                    {
                        if (doc is Mapa mapa)
                        {
                            cantidad += 1;
                            extension += mapa.Superficie;
                            sb.AppendLine(mapa.ToString());
                        }
                    }
                }

                if (escaner.Tipo == Escaner.TipoDoc.libro)
                {
                    if (doc.Estado == Documento.Paso.EnRevision)
                        if (doc is Libro libro)
                        {
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

        public static void MostrarTerminados(Escaner escaner, out int extension, out int cantidad, out string resumen)
        {
            cantidad = 0;
            extension = 0;
            resumen = "";
            StringBuilder sb = new StringBuilder();


            foreach (Documento doc in escaner.ListaDocumentos)
            {
                if (escaner.Tipo == Escaner.TipoDoc.mapa)
                {
                    if (doc.Estado == Documento.Paso.Terminado)
                    {
                        if (doc is Mapa mapa)
                        {
                            cantidad += 1;
                            extension += mapa.Superficie;
                            sb.AppendLine(mapa.ToString());
                        }
                    }
                }

                if (escaner.Tipo == Escaner.TipoDoc.libro)
                {
                    if (doc.Estado == Documento.Paso.Terminado)
                        if (doc is Libro libro)
                        {
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

        static void MostrarDocumentosPorEstado(Escaner escaner, Documento.Paso estado, out int extension, out int cantidad, out string resumen)
        {
            if (estado == Documento.Paso.Distribuido)
            {
                MostrarDistribuidos(escaner, out extension, out cantidad, out resumen);
            }
            else if (estado == Documento.Paso.EnEscaner)
            {
                MostrarEnEscaner(escaner, out extension, out cantidad, out resumen);
            }
            else if (estado == Documento.Paso.EnRevision)
            {
                MostrarEnRevision(escaner, out extension, out cantidad, out resumen);
            }
            else
            {
                MostrarTerminados(escaner, out extension, out cantidad, out resumen);
            }

        }



    }





}
