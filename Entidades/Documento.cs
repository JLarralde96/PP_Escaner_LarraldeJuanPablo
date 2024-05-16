using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Documento
    {

        public enum Paso {Inicio, Distribuido, EnEscaner, EnRevision, Terminado}

        //Atributos

        int anio;
        string autor;
        string barcode;
        Paso estado = Paso.Inicio;
        string numNormalizado;
        string titulo;

        //Constructores
        public Documento(int anio, string autor, string barcode, string numNormalizado, string titulo)
        {
            this.anio = anio;
            this.autor = autor;
            this.barcode = barcode;
            this.numNormalizado = numNormalizado;
            this.titulo = titulo;
        }

        //Propiedades
        public int Anio { get => anio;}
        public string Autor { get => autor;}
        public string Barcode { get => barcode;}
        public Paso Estado { get => estado;}
        protected string NumNormalizado { get => numNormalizado;}
        public string Titulo { get => titulo;}

        //Metodo


        /*
        Primero pregunta por el estado
        del objeto. Si el estado es el ultimo de la
        enumeracion entonces retorna false.
        Caso contrario avanza el estado y devuelve true.
         */
        public bool AvanzarEstado()
        {
            //Excepciones
            if (this.estado == Paso.Terminado)
            {
                return false;
            }
            else 
            {
                this.estado += 1;
                return true;
            }
        }



        /*
         Crea un objeto constructor de string al cual le va agregado
        la informacion que quiero mosrar. Finalmente retorna el String final.
         */
        public virtual string ToString()
        {
            StringBuilder documento = new StringBuilder();
            documento.AppendLine($"Título: {Titulo}");
            documento.AppendLine($"Autor: {Autor}");
            documento.AppendLine($"Año: {Anio}");
            return documento.ToString();
        }
        




    }
}
