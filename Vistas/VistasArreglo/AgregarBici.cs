using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoV2.BackendArreglos;
using ProyectoV2.Vistas;

namespace ProyectoV2.Vistas
{
    public partial class AgregarBici : Form
    {
        private Bicicletas editBicicleta;
        private Bicicletas nuevaBicicleta;
        private Arreglos arreglos;
        private CatalogoArreglo catalogoArreglo;


        public AgregarBici(Arreglos arreglos, CatalogoArreglo catalogoArreglo, Bicicletas bicixd )
        {
            InitializeComponent();
            this.arreglos = arreglos;
            this.catalogoArreglo = catalogoArreglo;
            nuevaBicicleta = new Bicicletas();
            editBicicleta = bicixd;
            
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(cmbTamaño.Text) || string.IsNullOrWhiteSpace(cmbTalla.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (editBicicleta != null)
            {



                editBicicleta.Nombre = txtNombre.Text;
                editBicicleta.Talla = Convert.ToDouble(cmbTalla.Text);
                editBicicleta.Tamaño = cmbTamaño.Text;
                arreglos.EditarBicicleta(editBicicleta);
                this.Close();
                return;

            }

            try
            {
                nuevaBicicleta.Id = ObtenerID();
                nuevaBicicleta.Nombre = txtNombre.Text;
                nuevaBicicleta.Talla = Convert.ToDouble(cmbTalla.Text);
                nuevaBicicleta.Tamaño = cmbTamaño.Text;
                arreglos.AgregarBicis(nuevaBicicleta);

                catalogoArreglo.ActualizarDataGridView();
                this.Close();
                catalogoArreglo.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la bicicleta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(cmbTamaño.Text) || string.IsNullOrWhiteSpace(cmbTalla.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (editBicicleta != null)
            {



                editBicicleta.Nombre = txtNombre.Text;
                editBicicleta.Talla = Convert.ToDouble(cmbTalla.Text);
                editBicicleta.Tamaño = cmbTamaño.Text;
                arreglos.EditarBicicleta(editBicicleta);
                this.Close();
                return;

            }

            try
            {
                nuevaBicicleta.Id = ObtenerID();
                nuevaBicicleta.Nombre = txtNombre.Text;
                nuevaBicicleta.Talla = Convert.ToDouble(cmbTalla.Text);
                nuevaBicicleta.Tamaño = cmbTamaño.Text;
                arreglos.AgregarBicisAlInicio(nuevaBicicleta);

                catalogoArreglo.ActualizarDataGridView();
                this.Close();
                catalogoArreglo.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la bicicleta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(cmbTamaño.Text) || string.IsNullOrWhiteSpace(cmbTalla.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (editBicicleta != null)
            {



                editBicicleta.Nombre = txtNombre.Text;
                editBicicleta.Talla = Convert.ToDouble(cmbTalla.Text);
                editBicicleta.Tamaño = cmbTamaño.Text;
                arreglos.EditarBicicleta(editBicicleta);
                this.Close();
                return;

            }

            try
            {
                nuevaBicicleta.Id = ObtenerID();
                nuevaBicicleta.Nombre = txtNombre.Text;
                nuevaBicicleta.Talla = Convert.ToDouble(cmbTalla.Text);
                nuevaBicicleta.Tamaño = cmbTamaño.Text;
                arreglos.AgregarBicisAlMedio(nuevaBicicleta);

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
            return arreglos.ObtenerUltimoID() + 1;
        }

        private void AgregarBici_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void volverButton_Click(object sender, EventArgs e)
        {
            this.Close();
            catalogoArreglo.Show();
        }

        private void cmbTalla_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
