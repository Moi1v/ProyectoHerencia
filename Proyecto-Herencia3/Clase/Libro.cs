using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Herencia3.Clase
{
    internal class Libro

    {

        private string titulo;
        private string autor;
        private string añopublicacion;
        private string generoliterario;
        private string mostrarinformacion;
        private DateTime FechaDeSalida;
        private DateTime FechaDeEntrega;


        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AñoPublicacion { get; set; }
        public string GeneroLiterario { get; set; }
        public string MostrarInformacion { get; set; }
        public DateTime fechaDeSalida { get; set; }
        public DateTime fechaDeEntrega { get; set; }


    }
}


