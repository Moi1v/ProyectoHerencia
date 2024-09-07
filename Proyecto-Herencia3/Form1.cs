using Proyecto_Herencia3.Clase;

namespace Proyecto_Herencia3
{
    public partial class Form1 : Form
    {
        Libro MiLibro = new Libro();
        LibroElectronico MiElectronico = new LibroElectronico();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                error1.SetError(textBox1, "Debe Ingresar Un Nombre Para El Miembro");
                textBox1.Focus();
                return;
            }
            error1.SetError(textBox1, "");

            decimal textbox2;
            if (!Decimal.TryParse(textBox2.Text, out textbox2))
            {
                error1.SetError(textBox2, "Debe Ingresar Un Año De Creacion");
                textBox2.Focus();
                return;
            }
            error1.SetError(textBox2, "");

            DateTime Fecha;
            if (!DateTime.TryParse(textBox3.Text, out Fecha))
            {
                error1.SetError(textBox3, "Debe Ingresar La Fecha De Salida");
                textBox3.Focus();
                return;
            }
            error1.SetError(textBox3, "");

            if (textBox4.Text == "")
            {
                error1.SetError(textBox4, "Debe Ingresar Un Nombre Para El Libro");
                textBox4.Focus();
                return;
            }
            error1.SetError(textBox4, "");

            MiLibro.Autor = textBox1.Text;
            MiLibro.AñoPublicacion = Convert.ToInt32(textBox2.Text);
            MiLibro.fechaDeSalida = Convert.ToDateTime(textBox3.Text);
            MiLibro.Titulo = textBox4.Text;

            MessageBox.Show("Datos Guardados Correctamente");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime FechaDeEntrega = DateTime.Today.AddDays(30);

            textBox5.Text = FechaDeEntrega.ToString();
            textBox6.Text = FechaDeEntrega.DayOfWeek.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
