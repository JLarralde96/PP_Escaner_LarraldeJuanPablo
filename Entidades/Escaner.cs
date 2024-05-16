using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Escaner
    {
        //Atributos
        public enum Departamento {nulo, mapoteca, procesosTecnicos}
        public enum TipoDoc {libro, mapa}


        List<Documento> listaDocumentos;
        Departamento locacion;
        string marca;
        TipoDoc tipo;

        //Constructores
        public Escaner(string marca, TipoDoc tipo)
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

        //Propiedades
        public List<Documento> ListaDocumentos { get => listaDocumentos;}
        public Departamento Locacion { get => locacion;}
        public string Marca { get => marca;}
        public TipoDoc Tipo { get => tipo;}

        public static bool operator ==(Escaner escaner, Documento documento)
        {
            bool igual = false;

            if (escaner.listaDocumentos.Contains(documento))
            {
                igual = true;
            }

            return igual;

            

        }

        public static bool operator !=(Escaner escaner, Documento documento)
        {

            return !(escaner == documento);

        }

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
