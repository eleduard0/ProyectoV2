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

                
                if (editBicicleta == null)
                {
                    
                    pilas.Insertar(nuevaBicicleta);
                }
                else
                {
                    
                    ActualizarBicicletaExistente();
                }

                
                catalogoPilas.ActualizarGridView();

                
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
