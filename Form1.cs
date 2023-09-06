using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_Ejercicio_1
{
    public partial class Form1 : Form
    {
        private Ingresar ingresar;
        // Declaraciones Globales
        Persona[] Instancia = variables.Instancia;


        int N;
        int a = 0;

        public void Imprimir()
        {
            dgElementos.DataSource = null;
            dgElementos.DataSource = variables.Instancia;
        }

            public Form1()
        {
            InitializeComponent();
        }

        Ingresar InstanciaIngresar = new Ingresar();

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("BIENVENIDOS");
        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ingresar modal = new Ingresar(this);
            modal.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (variables.a >= 0 && variables.a < variables.N)
            {
                // Crea una nueva instancia del arreglo con un tamaño menor
                Persona[] nuevaInstancia = new Persona[variables.N - 1];
                for (int i = variables.a; i < variables.N -1; i++)
                {
                    nuevaInstancia[i] = variables.Instancia[i];
                }

                // Actualiza la referencia a la instancia y decrementa el contador N
                variables.Instancia = nuevaInstancia;
                variables.N--;

                // Llama a la función Imprimir() en Form1
                Imprimir();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Seleccione una fila valida en la DataGridView.");
            }
        }
        public void Limpiar()
        {
            txtDiezmo.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
        }
        private void dgElementos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            a = e.RowIndex;

            // Accede a los controles de Ingresar a través de la instancia de Ingresar
            if (InstanciaIngresar != null)
            {
                txtNombre.Text = dgElementos.Rows[a].Cells[0].Value.ToString();
                txtDireccion.Text = dgElementos.Rows[a].Cells[1].Value.ToString();
                txtTelefono.Text = dgElementos.Rows[a].Cells[2].Value.ToString();
                dtMes.Value = DateTime.Parse(dgElementos.Rows[a].Cells[3].Value.ToString());
                txtDiezmo.Text = dgElementos.Rows[a].Cells[4].Value.ToString();
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
