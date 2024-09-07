using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Herencia3.Clase
{
    internal class LibroFisico : Libro
    {
        public int CodigoProducto { get; set; }
        public string UbicacionBiblioteca { get; set; }
        public LibroFisico(string Titulo, string Autor, int AñoPublicacion, string GeneroLiterario, int CodigoProducto, string UbicacionBiblioteca)
        {
            this.CodigoProducto = CodigoProducto;
            this.UbicacionBiblioteca = UbicacionBiblioteca;
        }
        public virtual void MostrarInformacion()
        {
            Console.WriteLine(value: $"Codigo del libro: {CodigoProducto}, Ubicación de la biblioteca: {UbicacionBiblioteca} ");
        }
    }

}

