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
        public Mapa(int anio, string autor, string barcode,string titulo, int ancho, int alto, string numNormalizado = null) 
            : base(anio, autor, barcode, numNormalizado, titulo)
        {
            this.ancho = ancho;
            this.alto = alto;
        }
       
        //Porpiedades
        public int Ancho { get => ancho;}
        public int Alto { get => alto;}

        public int Superficie
        {
            get => Ancho * Alto;
        }

        //Metodos

        public static bool operator ==(Mapa mapa, Mapa mapaDos)
        {
            bool igual = false;

            if ((mapa.Barcode == mapaDos.Barcode) ||
                 (mapa.Titulo == mapa.Titulo) && (mapa.Autor == mapa.Autor) && (mapa.Anio == mapa.Anio) && (mapa.Superficie == mapa.Superficie))
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
            mapa.AppendLine($"Superficie: {Superficie}");
            return mapa.ToString();
        }

    }
}
