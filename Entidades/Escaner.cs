using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Escaner
    {
        //Atributos
        public enum Departamento { nulo, mapoteca, procesosTecnicos }
        public enum TipoDoc { libro, mapa }


        List<Documento> listaDocumentos;
        Departamento locacion;
        string marca;
        TipoDoc tipo;

        //Constructores

        /*
         * Aca aplico un try catch en el constructor porque noe stoy seguro cuales osn los posibles probelams que nos pueda presentar el simulador y entiendo q uno es 
         * un dato invalido en la construccion del objeto. A su vez el constructor pregunta por el tipo de documento ingresado y en base a eso define el departamento
         * del escaner.
         */
        public Escaner(string marca, TipoDoc tipo)
        {
            try
            {
                this.listaDocumentos = new List<Documento> { };
                this.marca = marca;
                this.tipo = tipo;

                if (tipo == TipoDoc.mapa)
                {
                    this.locacion = Departamento.mapoteca;
                }
                else if (tipo == TipoDoc.libro)
                {
                    this.locacion = Departamento.procesosTecnicos;
                }
                else
                {
                    this.locacion = Departamento.nulo;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }





        //Propiedades
        public List<Documento> ListaDocumentos { get => listaDocumentos; }
        public Departamento Locacion { get => locacion; }
        public string Marca { get => marca; }
        public TipoDoc Tipo { get => tipo; }


        /*
         * 
         * Si el documento se encuentra dentro del escaner devuelve true, usamos el metodo Contains. 
         * 
         */

        public static bool operator ==(Escaner escaner, Documento documento)
        {

            bool igual = false;

            try
            {
                if (documento is Mapa doc)
                {
                    if (escaner.Tipo == TipoDoc.mapa)
                    {
                        foreach (Mapa mapa in escaner.listaDocumentos)
                        {
                            if (doc == mapa)
                            {
                                igual = true;
                            }
                        }
                    }
                    else
                    {
                        igual = false;
                    }
                }
                else if (documento is Libro docu)
                {
                    if (escaner.Tipo == TipoDoc.libro)
                    {
                        foreach (Libro libro in escaner.listaDocumentos)
                        {
                            if (docu == libro)
                            {
                                igual = true;
                            }
                        }
                    }
                    else
                    {
                        igual = false;
                    }
                }

                return igual;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("El escaner o el documento no pueden ser nulos");
                return igual;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR {ex}");
                return igual;
            }


        }

        public static bool operator !=(Escaner escaner, Documento documento)
        {

            return !(escaner == documento);

        }


        /*
         * Primero usamos la sobrecarga anteior, preguntamos si el docuemnto no esta en la lista. En ese caso vemos q el documento este en estado Inicio.
         * desp chequeamos que el tipo de documento este en el escaner correcto, ya que hay escaners para mapas y otos para libros. Y recien ahi lo ingresamos y le avanzamos el estado.
         */

        public static bool operator +(Escaner escaner, Documento documento)
        {

            bool retorno = false;

            if (escaner != documento)
            {
                if (documento.Estado == Documento.Paso.Inicio)
                {
                    if ((escaner.Tipo == TipoDoc.mapa) && (documento is Mapa))
                    {
                        documento.AvanzarEstado();
                        escaner.listaDocumentos.Add(documento);
                        retorno = true;
                    }

                    else if ((escaner.Tipo == TipoDoc.libro) && (documento is Libro))
                    {
                        documento.AvanzarEstado();
                        escaner.listaDocumentos.Add(documento);
                        retorno = true;
                    }
                    else
                    {
                        retorno = false;
                    }
                }


            }

            return retorno;

        }


        /*
         * 
         * Si el documento esta en el escaner cambiamos el estado. +1 en el enum de estados. 
         */

        public bool CambiarEstadoDocumento(Documento documento)
        {

            bool igual = false;

            if (this == documento)
            {
                igual = true;
                documento.AvanzarEstado();

            }

            return igual;

        }




    }
}
