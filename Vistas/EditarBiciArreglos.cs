using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoV2.Vistas
{
    public partial class EditarBiciArreglos : Form
    {
        private CatalogoArreglo catalogoArreglo;
        private Bicicletas bicicletaActual;

        public EditarBiciArreglos(CatalogoArreglo catalogoArreglo, Bicicletas bicicletaActual)
        {
            InitializeComponent();
            this.catalogoArreglo = catalogoArreglo;
            this.bicicletaActual = bicicletaActual;

            // Inicializar controles con valores de la bicicleta actual
            txtNombre.Text = bicicletaActual.Nombre;
            cmbTamaño.Text = bicicletaActual.Tamaño;
            cmbTalla.Text = bicicletaActual.Talla;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Actualizar valores de la bicicleta actual con los valores de los controles
            bicicletaActual.Nombre = txtNombre.Text;
            bicicletaActual.Tamaño = cmbTamaño.Text;
            bicicletaActual.Talla = cmbTalla.Text;

            // Actualizar el DataGridView en el formulario principal
            catalogoArreglo.ActualizarDataGridView();

            // Mostrar el formulario principal y cerrar el formulario de edición
            catalogoArreglo.Show();
            this.Close();
        }
    }

}
