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
    public partial class CategolodeListas : Form
    {
        private ListaEnlazada listaEnlazada;
        private Arreglos arreglo;
        Bicicletas bicicletaSeleccionada;

        public CategolodeListas(ListaEnlazada lista)
        {
            InitializeComponent();
            listaEnlazada = lista;
            ActualizarDataGridView();
        }

        public void ActualizarDataGridView()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = listaEnlazada.ObtenerListaEnlazadaBicicletas();
        }

        private void CategolodeListas_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscaar_TextChanged(object sender, EventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            if (listaEnlazada.ListaVacia())
            {
                MessageBox.Show("La lista esta vacia!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BicisBusqueda();
        }
        public void BicisBusqueda()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = listaEnlazada.Buscar(txtBuscaar.Text);
        }

        private void agregarBici_Click(object sender, EventArgs e)
        {
            Agregar agregar = new Agregar(this, listaEnlazada, bicicletaSeleccionada);
            this.Hide();
            agregar.Show();
        }

        private void editarBiciA_Click(object sender, EventArgs e)
        {
            if (listaEnlazada.ListaVacia())
            {
                MessageBox.Show("La lista esta vacia!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

                Bicicletas bicicletaSeleccionada = (Bicicletas)dataGridView1.Rows[rowIndex].DataBoundItem;

                Agregar agregar = new Agregar(this, listaEnlazada, bicicletaSeleccionada);
                this.Hide();

                agregar.Show();

                agregar.FormClosed += Agregar_FormClosed;
               
            }
        }
        private void Agregar_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            ActualizarDataGridView();
        }

        private void eliminarBiciA_Click(object sender, EventArgs e)
        {
            if (listaEnlazada.ListaVacia())
            {
                MessageBox.Show("La lista esta vacia!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridView1.SelectedCells.Count > 0)
            {

                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;


                Bicicletas bicicletaSeleccionada = (Bicicletas)dataGridView1.Rows[rowIndex].DataBoundItem;


                EliminarBicicleta(bicicletaSeleccionada);


                ActualizarDataGridView();
            }
        }
        private void EliminarBicicleta(Bicicletas bicixd)
        {

            listaEnlazada.Eliminar(bicixd);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listaEnlazada.ListaVacia())
            {
                MessageBox.Show("La lista esta vacia!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            listaEnlazada.OrdenarAscendente();
            ActualizarDataGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listaEnlazada.ListaVacia())
            {
                MessageBox.Show("La lista esta vacia!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            listaEnlazada.OrdenarDescendente();
            ActualizarDataGridView();
        }
    }
}
