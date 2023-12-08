using ProyectoV2.BackendArreglos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoV2.Vistas.VistasArreglo
{
    public partial class VistaLongitud : Form
    {
        
        public VistaLongitud()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VistaLongitud_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLongitud.Text))
            {
                MessageBox.Show("Por favor ingrese la longitud del arrelgo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int longitud = int.Parse(txtLongitud.Text);
                Arreglos arreglo = new Arreglos(longitud);

                CatalogoArreglo catalogo = new CatalogoArreglo(arreglo);
                catalogo.Show();
                this.Hide();



            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error, intentelo de nuevo {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
