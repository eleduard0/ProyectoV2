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
using ProyectoV2.BackendPila;

namespace ProyectoV2.Vistas.VistasPilas
{
    public partial class TamañoPilas : Form
    {
        private Pilas pilas;

        public TamañoPilas()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTamaño.Text))
            {
                MessageBox.Show("Por favor ingrese la longitud del arreglo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int longitud = int.Parse(txtTamaño.Text);
                pilas = new Pilas(longitud);

                CatalogoPilas catalogo = new CatalogoPilas(pilas);
                catalogo.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error, inténtelo de nuevo {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
