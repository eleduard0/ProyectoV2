using ProyectoV2.BackendCola;
using ProyectoV2.BackendPila;
using ProyectoV2.Vistas.VistasPilas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoV2.Vistas.VistasColas
{
    public partial class TamañoColas : Form
    {
        private Colas colas;
        public TamañoColas()
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
                colas = new Colas(longitud);

                CatalogoColas catalogo = new CatalogoColas(colas);
                catalogo.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error, inténtelo de nuevo {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            this.Close();
            inicio.ShowDialog();
        }
    }
}
