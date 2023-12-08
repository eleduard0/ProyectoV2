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
    public partial class CatalogoColas : Form
    {
        private Colas colas;
        private Bicicletas bicicletas;
        public CatalogoColas(Colas colas)
        {
            InitializeComponent();
            this.colas = colas;
            ActualizarGridView();
        }
        public void ActualizarGridView()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = colas.ObtenerArregloBicicletas();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            new Inicio().Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (colas.EstaLlena())
            {
                MessageBox.Show("Lo siento, la cola de bicis está llena!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AgregarACola agregarACola = new AgregarACola(colas, this, bicicletas);
            this.Hide();
            agregarACola.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

                Bicicletas bicicletaSeleccionada = (Bicicletas)dataGridView1.Rows[rowIndex].DataBoundItem;

                AgregarACola agregarBici = new AgregarACola(colas, this, bicicletaSeleccionada);
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
                    colas.EliminarBicicleta(bicicletaSeleccionada.Id);
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
