using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoV2.Vistas;

namespace ProyectoV2.Vistas
{
    public partial class AgregarBici : Form
    {
        private Bicicletas nuevaBicicleta;
        private CatalogoArreglo catalogoArreglo;

        public AgregarBici(CatalogoArreglo catalogoArreglo)
        {
            InitializeComponent();
            this.catalogoArreglo = catalogoArreglo;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(cmbTamaño.Text) || string.IsNullOrWhiteSpace(cmbTalla.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                nuevaBicicleta = new Bicicletas { Id = ObtenerID(), Nombre = txtNombre.Text, Tamaño = cmbTamaño.Text, Talla = cmbTalla.Text };

                catalogoArreglo.AgregarBicicleta(nuevaBicicleta);
                catalogoArreglo.ActualizarDataGridView();
                this.Close();
                catalogoArreglo.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la bicicleta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ObtenerID()
        {
            return catalogoArreglo.ObtenerUltimoID() + 1;
        }
    }
}
