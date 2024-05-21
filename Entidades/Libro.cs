using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Entidades
{
    public class Libro : Documento
    {
        //Atributos

        int numPaginas;


        //Constructores
        public Libro(string titulo, string autor, int anio, string numNormalizado, string barcode, int numPaginas)
            : base(titulo,autor, anio, numNormalizado, barcode)
        {
            try
            {
                this.numPaginas = numPaginas;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        //Propiedades
        public int NumPaginas { get => numPaginas; }

        public string ISBN { get => NumNormalizado; }

        //Metodos


        /*
         Hace que en una igualacion de objetos de tipo libro se evalue soalmente
        si alguno de los atributos claves son iguales. EN caso de que asi sea entonce nos
        encontramos frente al mismo libro
        Debajo esta la sobrecarga complementaria a la de == que es la de disntinto donde simplemente decimos
        que mientras sea distinta a lo establecido en la igualacion es distinta la comparacion.
         */
        public static bool operator ==(Libro libro, Libro libroDos)
        {
            bool igual = false;

            if ((libro.Barcode == libroDos.Barcode) ||
                 (libro.ISBN == libroDos.ISBN) ||
                 (libro.Titulo == libroDos.Titulo) && (libro.Autor == libroDos.Autor))
            {
                igual = true;
            }

            return igual;

        }

        public static bool operator !=(Libro libro, Libro libroDos)
        {

            return !(libro == libroDos);

        }

        /*
         Crea un objeto constructor de string al cual le va agregado
        la informacion que quiero mosrar. Finalmente retorna el String final.
         */
        public override string ToString()
        {
            StringBuilder libro = new StringBuilder();
            libro.Append(base.ToString());
            libro.AppendLine($"ISBN: {ISBN}");
            libro.AppendLine($"Cód. de barras: {Barcode}");
            libro.AppendLine($"Número de páginas: {NumPaginas}");
            return libro.ToString();
        }
    }
}
