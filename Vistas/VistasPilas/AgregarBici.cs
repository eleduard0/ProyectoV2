using ProyectoV2.BackendPila;
using System;
using System.Windows.Forms;

namespace ProyectoV2.Vistas.VistasPilas
{
    public partial class AgregarBici : Form
    {
        private Bicicletas editBicicleta;
        private Bicicletas nuevaBicicleta;
        private Pilas pilas;
        private CatalogoPilas catalogoPilas;

        public AgregarBici(Pilas pilas, CatalogoPilas catalogo, Bicicletas bicicleta)
        {
            InitializeComponent();
            this.pilas = pilas;
            catalogoPilas = catalogo;
            nuevaBicicleta = new Bicicletas();
            editBicicleta = bicicleta;

            if (editBicicleta != null)
            {
                // Si se está editando, establecer los valores actuales en los controles
                txtNombre.Text = editBicicleta.Nombre;
                cmbTalla.Text = editBicicleta.Talla.ToString();
                cmbTamaño.Text = editBicicleta.Tamaño;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                // Llenar los datos de la nueva bicicleta
                nuevaBicicleta.Id = ObtenerID();
                nuevaBicicleta.Nombre = txtNombre.Text;
                nuevaBicicleta.Talla = double.Parse(cmbTalla.Text);
                nuevaBicicleta.Tamaño = cmbTamaño.Text;

                // Insertar o actualizar la bicicleta en la pila
                if (editBicicleta == null)
                {
                    // Agregar una nueva bicicleta
                    pilas.Insertar(nuevaBicicleta);
                }
                else
                {
                    // Actualizar la bicicleta existente
                    ActualizarBicicletaExistente();
                }

                // Actualizar el DataGridView en el formulario CatalogoPilas
                catalogoPilas.ActualizarGridView();

                // Cerrar el formulario actual y mostrar el formulario CatalogoPilas
                this.Close();
                catalogoPilas.Show();
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
            return pilas.ObtenerUltimoID() + 1;
        }

        private void ActualizarBicicletaExistente()
        {
            // Actualizar la bicicleta existente con los nuevos valores
            editBicicleta.Nombre = txtNombre.Text;
            editBicicleta.Talla = double.Parse(cmbTalla.Text);
            editBicicleta.Tamaño = cmbTamaño.Text;
            pilas.EditarBicicleta(editBicicleta.Id, editBicicleta);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CatalogoPilas(pilas).Show();
            this.Close();
        }
    }
}
