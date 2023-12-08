using ProyectoV2.BackendArreglos;
using ProyectoV2.BackendPila;
using System;
using System.Windows.Forms;

namespace ProyectoV2.Vistas.VistasPilas
{
    public partial class CatalogoPilas : Form
    {
        private Pilas pilas;
        private Bicicletas bicicletaSeleccionada;

        public CatalogoPilas(Pilas pilas)
        {
            InitializeComponent();
            this.pilas = pilas;
            ActualizarGridView();
        }

        public void ActualizarGridView()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = pilas.ObtenerArregloBicicletas();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            
            new Inicio().Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (pilas.EstaLlena())
            {
                MessageBox.Show("Lo siento, el arreglo de bicis está lleno!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Pasar pilas como argumento al formulario AgregarBici
            AgregarBici agregarBici = new AgregarBici(pilas, this, bicicletaSeleccionada);
            this.Hide();
            agregarBici.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

                Bicicletas bicicletaSeleccionada = (Bicicletas)dataGridView1.Rows[rowIndex].DataBoundItem;

                AgregarBici agregarBici = new AgregarBici(pilas, this, bicicletaSeleccionada);
                this.Hide();


                agregarBici.FormClosed += AgregarBici_FormClosed;

                agregarBici.Show();
            }
        }
        private void AgregarBici_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            ActualizarGridView();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                Bicicletas bicicletaSeleccionada = (Bicicletas)dataGridView1.Rows[rowIndex].DataBoundItem;

                try
                {
                    pilas.EliminarBicicleta(bicicletaSeleccionada.Id);
                    MessageBox.Show("Bicicleta eliminada exitosamente", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Actualizar el DataGridView
                    ActualizarGridView();
                    // Forzar la actualización visual del DataGridView
                    dataGridView1.Refresh();
                    // Forzar la repintura del DataGridView
                    dataGridView1.Invalidate();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show($"Error al eliminar bicicleta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
