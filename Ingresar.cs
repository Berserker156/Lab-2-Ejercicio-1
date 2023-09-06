using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_Ejercicio_1
{
    public partial class Ingresar : Form
    {
        private Form1 form1;

        public string Nombre
        {
            get { return txtNombre.Text; }
            set { txtNombre.Text = value; }
        }

        public string Direccion
        {
            get { return txtDireccion.Text; }
            set { txtDireccion.Text = value; }
        }

        public string Telefono
        {
            get { return txtTelefono.Text; }
            set { txtTelefono.Text = value; }
        }

        public DateTime Mes
        {
            get { return dtMes.Value; }
            set { dtMes.Value = value; }
        }

        public string Diezmo
        {
            get { return txtDiezmo.Text; }
            set { txtDiezmo.Text = value; }
        }
        // Constructor sin argumentos (por defecto)
        public Ingresar()
        {
            InitializeComponent();
        }
        private int contadorId = 1;

        // Constructor que recibe una referencia a Form1
        public Ingresar(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }
        public void Limpiar()
        {
            txtDiezmo.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
        }
        private void Ingresar_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void txtDiezmo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Crea una nueva Persona
            Persona nuevaPersona = new Persona(contadorId, txtNombre.Text, txtDireccion.Text, txtTelefono.Text, DateTime.Parse(dtMes.Text), double.Parse(txtDiezmo.Text));

            // Crea una nueva instancia del arreglo y copia los elementos actuales
            Persona[] nuevaInstancia = new Persona[variables.N + 1];
            for (int i = 0; i < variables.N; i++)
            {
                nuevaInstancia[i] = variables.Instancia[i];
            }

            // Agrega la nueva Persona al arreglo
            nuevaInstancia[variables.N] = nuevaPersona;

            // Actualiza la referencia a la instancia
            variables.Instancia = nuevaInstancia;
            variables.N++;
            

            // Llama a la función Imprimir() en Form1
            form1.Imprimir();
            contadorId++;
            Limpiar();
        }

        private void dgElementos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
