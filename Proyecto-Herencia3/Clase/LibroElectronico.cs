using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Herencia3.Clase
{
    internal class LibroElectronico : Libro
    {

        private int tamañoarchivo;
        private string formato;

        public int Archivo { get; set; }
        public string Formato { get; set; }

        public decimal Tamano(int Archivo)
        {
            int TamanoTotal = Archivo + 0;
            return TamanoTotal;
        }
    }
}