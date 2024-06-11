using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class MiExcepcion : Exception
    {
        string nombreClase;
        string nombreMetodo;

        public string NombreClase { get => this.nombreClase; }
        public string NombreMetodo { get => this.nombreMetodo; }

        public MiExcepcion(string mensaje, string nombreClase, string nombreMetodo)
            : base(mensaje)
        {
            this.nombreClase = nombreClase;
            this.nombreMetodo = nombreMetodo;
        }
        public MiExcepcion(string mensaje, string nombreClase, string nombreMetodo, Exception innerException)
            : base(mensaje, innerException)
        {
            this.nombreClase = nombreClase;
            this.nombreMetodo = nombreMetodo;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Excepcion en el {nombreMetodo} de la clase {nombreClase}");
            sb.AppendLine($"Tipo no valido");
            sb.AppendLine($"Detalles: {Message}");
            return sb.ToString();
        }
    }
}
