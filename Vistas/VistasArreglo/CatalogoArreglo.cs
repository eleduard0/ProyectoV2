using ProyectoV2.BackendArreglos;
using ProyectoV2.Vistas;
using System;
using System.Linq;
using ProyectoV2.Vistas;
using System.Windows.Forms;
using ProyectoV2.Vistas.VistasArreglo;

namespace ProyectoV2
{
    public partial class CatalogoArreglo : Form
    {
        private Arreglos arreglos;
        Bicicletas bicicletaSeleccionada;
        OrdenandoMensaje ordenando;

        public CatalogoArreglo(Arreglos arreglosx)
        {
            InitializeComponent();
            arreglos = arreglosx;
            ordenando = new OrdenandoMensaje(this);
            ActualizarDataGridView();

        }

        public void ActualizarDataGridView()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = arreglos.ObtenerArregloBicicletas();
        }



        private void agregarBici_Click(object sender, EventArgs e)
        {
            if (arreglos.ArregloLleno())
            {
                MessageBox.Show("Lo siento, el arreglo de bicis esta lleno!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AgregarBici agregarBici = new AgregarBici(arreglos, this, bicicletaSeleccionada);
            this.Hide();
            agregarBici.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (arreglos.ArregloLleno())
            {
                MessageBox.Show("Lo siento, el arreglo de bicis esta lleno!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (arreglos.ArregloLleno())
            {
                MessageBox.Show("Lo siento, el arreglo de bicis esta lleno!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }




        private void volverButton_Click(object sender, EventArgs e)
        {
            Inicio form = new Inicio();
            this.Close();
            form.ShowDialog();
        }

        private void CatalogoArreglo_Load(object sender, EventArgs e)
        {

        }


        private void editarBiciA_Click(object sender, EventArgs e)
        {
            if (arreglos.ArregloVacio())
            {
                MessageBox.Show("El arreglo está vacío!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridView1.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

                if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
                {
                    Bicicletas bicicletaSeleccionada = (Bicicletas)dataGridView1.Rows[rowIndex].DataBoundItem;

                    AgregarBici agregarBici = new AgregarBici(arreglos, this, bicicletaSeleccionada);
                    this.Hide();

                    agregarBici.FormClosed += AgregarBici_FormClosed;

                    agregarBici.Show();
                }
                else
                {
                    MessageBox.Show("La fila seleccionada no es válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No seleccionaste ninguna bici!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void AgregarBici_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            ActualizarDataGridView();
        }

        private void eliminarBiciA_Click(object sender, EventArgs e)
        {
            if (arreglos.ArregloVacio())
            {
                MessageBox.Show("El arreglo esta vació!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridView1.SelectedCells.Count > 0)
            {

                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;


                int idBicicleta = (int)dataGridView1.Rows[rowIndex].Cells["Id"].Value;


                EliminarBicicleta(idBicicleta);


                ActualizarDataGridView();
            }
        }

        private void EliminarBicicleta(int idBicicleta)
        {

            arreglos.EliminarBicicleta(idBicicleta);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Establecer_Click(object sender, EventArgs e)
        {

        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (arreglos.ArregloVacio())
            {
                MessageBox.Show("El arreglo esta vació!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            arreglos.OrdenarAscendente();
            ActualizarDataGridView();
            this.Hide();
            ordenando.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (arreglos.ArregloVacio())
            {
                MessageBox.Show("El arreglo esta vació!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            arreglos.OrdenarDescendente();
            ActualizarDataGridView();
            this.Hide();
            ordenando.Show();

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            if (arreglos.ArregloVacio())
            {
                MessageBox.Show("El arreglo esta vació!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BicisBusqueda();
 
        }

        public void BicisBusqueda()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = arreglos.Buscar(txtBuscaar.Text);
        }

        
    }
}
