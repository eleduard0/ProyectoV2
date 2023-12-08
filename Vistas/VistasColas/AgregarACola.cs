using ProyectoV2.BackendCola;
using ProyectoV2.BackendPila;
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
    public partial class AgregarACola : Form
    {
        private Bicicletas editBicicleta;
        private Bicicletas nuevaBicicleta;
        private Colas colas;
        private CatalogoColas catalogoColas;
        public AgregarACola(Colas colas, CatalogoColas catalogo, Bicicletas bicicletas)
        {
            InitializeComponent();
            this.colas = colas;
            catalogoColas = catalogo;
            nuevaBicicleta = new Bicicletas();
            editBicicleta = bicicletas;
            if (editBicicleta != null)
            {
                txtNombre.Text = editBicicleta.Nombre;
                cmbTalla.Text = editBicicleta.Talla.ToString();
                cmbTamaño.Text = editBicicleta.Tamaño;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                nuevaBicicleta.Id = ObtenerID();
                nuevaBicicleta.Nombre = txtNombre.Text;
                nuevaBicicleta.Talla = double.Parse(cmbTalla.Text);
                nuevaBicicleta.Tamaño = cmbTamaño.Text;

                if(editBicicleta == null)
                {
                    colas.Insertar(nuevaBicicleta);
                }
                else
                {
                    ActualizarBicicletaExistente();
                }
                catalogoColas.ActualizarGridView();

                this.Close();
                catalogoColas.Show();
            }
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(cmbTamaño.Text) || string.IsNullOrWhiteSpace(cmbTalla.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private int ObtenerID()
        {
            return colas.ObtenerUltimoID() + 1;
        }
        private void ActualizarBicicletaExistente()
        {
            // Actualizar la bicicleta existente con los nuevos valores
            editBicicleta.Nombre = txtNombre.Text;
            editBicicleta.Talla = double.Parse(cmbTalla.Text);
            editBicicleta.Tamaño = cmbTamaño.Text;
            colas.EditarBicicleta(editBicicleta.Id, editBicicleta);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            new CatalogoColas(colas).Show();
            this.Close();
        }
    }
}
