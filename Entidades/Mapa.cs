using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Entidades
{
    public class Mapa : Documento
    {
        //Atributos

        int ancho;
        int alto;


        //Contructores
        public Mapa(string titulo, string autor, int anio, string numNormalizado, string barcode, int ancho, int alto)
            : base( titulo,  autor, anio,  numNormalizado,  barcode)
        {
            try
            {
                this.ancho = ancho;
                this.alto = alto;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        //Porpiedades
        public int Ancho { get => ancho; }
        public int Alto { get => alto; }

        public int Superficie
        {
            get => Ancho * Alto;
        }

        //Metodos

        /*
         * Preguntamos a traves de un condicional todas las posibles variables dadas en la consigna para que considerar al documento como el mismo documento. Si alguna se ucmple
         * el documento ya esta existe. Esto se usa luego cuando preguntamos si este documento se encuentra en el escaner. 
         */
        public static bool operator ==(Mapa mapa, Mapa mapaDos)
        {
            bool igual = false;

            if ((mapa.Barcode == mapaDos.Barcode) ||
                 (mapa.Titulo == mapaDos.Titulo) && (mapa.Autor == mapaDos.Autor) && (mapa.Anio == mapaDos.Anio) && (mapa.Superficie == mapaDos.Superficie))
            {
                igual = true;
            }

            return igual;

        }

        public static bool operator !=(Mapa mapa, Mapa mapaDos)
        {

            return !(mapa == mapaDos);
        }


        /*
         Crea un objeto constructor de string al cual le va agregado
        la informacion que quiero mosrar. Finalmente retorna el String final.
         */
        public override string ToString()
        {
            StringBuilder mapa = new StringBuilder();
            mapa.Append(base.ToString());
            mapa.AppendLine($"Cód. de barras: {Barcode}");
            mapa.AppendLine($"Superficie: {Ancho} * {Alto} = {Superficie}cm2.");
            return mapa.ToString();
        }

    }
}
