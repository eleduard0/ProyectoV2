using ProyectoV2.BackendArreglos;
using ProyectoV2.BackendListas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoV2.Vistas.VistasCatalogo
{
    public partial class Agregar : Form
    {
        private Bicicletas editBicicleta;
        private Bicicletas nuevaBicicleta;
        private ListaEnlazada listaEnlazada;
        private CategolodeListas catalogoListas;

        public Agregar(CategolodeListas catalogo, ListaEnlazada lista, Bicicletas bicixd)
        {
            InitializeComponent();
            catalogoListas = catalogo;
            listaEnlazada = lista;
            nuevaBicicleta = new Bicicletas();
            editBicicleta = bicixd;


        }

        private void Agregar_Load(object sender, EventArgs e)
        {

        }

        private int ObtenerID()
        {
            return listaEnlazada.ObtenerUltimoID() + 1;
        }

        // AGREGAR AL INICIOOO
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
                //listaEnlazada.EditarBicicleta(editBicicleta);
                this.Close();
                return;

            }

            try
            {
                nuevaBicicleta.Id = ObtenerID();
                nuevaBicicleta.Nombre = txtNombre.Text;
                nuevaBicicleta.Talla = Convert.ToDouble(cmbTalla.Text);
                nuevaBicicleta.Tamaño = cmbTamaño.Text;
                listaEnlazada.AgregarAlInicio(nuevaBicicleta);

                catalogoListas.ActualizarDataGridView();
                this.Close();
                catalogoListas.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la bicicleta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        


        /// AGREGAR AL MEDIOOOOO
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
                //listaEnlazada.EditarBicicleta(editBicicleta);
                this.Close();
                return;

            }

            try
            {
                nuevaBicicleta.Id = ObtenerID();
                nuevaBicicleta.Nombre = txtNombre.Text;
                nuevaBicicleta.Talla = Convert.ToDouble(cmbTalla.Text);
                nuevaBicicleta.Tamaño = cmbTamaño.Text;
                listaEnlazada.AgregarAlMedio(nuevaBicicleta);

                catalogoListas.ActualizarDataGridView();
                this.Close();
                catalogoListas.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la bicicleta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// AGREGAR AL FINAL
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
                //listaEnlazada.EditarBicicleta(editBicicleta);
                this.Close();
                return;

            }

            try
            {
                nuevaBicicleta.Id = ObtenerID();
                nuevaBicicleta.Nombre = txtNombre.Text;
                nuevaBicicleta.Talla = Convert.ToDouble(cmbTalla.Text);
                nuevaBicicleta.Tamaño = cmbTamaño.Text;
                listaEnlazada.AgregarAlFinal(nuevaBicicleta);

                catalogoListas.ActualizarDataGridView();
                this.Close();
                catalogoListas.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la bicicleta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
