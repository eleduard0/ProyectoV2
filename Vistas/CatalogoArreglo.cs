using ProyectoV2.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoV2
{
    public partial class CatalogoArreglo : Form
    {
        public Bicicletas[] arregloBicicletas;
       
        public CatalogoArreglo()
        {
            InitializeComponent();
            arregloBicicletas = new Bicicletas[10];
            AgregarBicisAuto();

        }
        public void AgregarBicicleta(Bicicletas nuevaBicicleta)
        {
            for (int i = 0; i < arregloBicicletas.Length; i++)
            {
                if (arregloBicicletas[i] == null)
                {
                    arregloBicicletas[i] = nuevaBicicleta;
                    break;
                }
            }
        }
        
        
       
        public void ActualizarDataGridView()
        {
            // Configura nuevamente el origen de datos del DataGridView después de realizar cambios
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = arregloBicicletas;
        }

        private void AgregarBicisAuto()
        {
            // Crear un arreglo de objetos de tipo Bicicletas
            //Bicicletas[] arregloBicicletas = new Bicicletas[3]; // Puedes ajustar el tamaño según tus necesidades

            // Llenar el arreglo con datos
            arregloBicicletas[0] = new Bicicletas { Id = 1, Nombre = "V10", Tamaño = "M", Talla = "29\"" };
            arregloBicicletas[1] = new Bicicletas { Id = 2, Nombre = "Megatower", Tamaño = "XL", Talla = "29\"" };
            arregloBicicletas[2] = new Bicicletas { Id = 3, Nombre = "Bullit", Tamaño = "L", Talla = "27\"" };

            // Configurar el DataGridView
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = arregloBicicletas;
        }
        public void EliminarBicicleta(int id)
        {
            // Verifica si el arreglo está inicializado y no es nulo
            if (arregloBicicletas != null)
            {
                // Busca la bicicleta con el ID especificado
                var bicicletaAEliminar = arregloBicicletas.FirstOrDefault(b => b?.Id == id);

                // Si se encontró la bicicleta, elimínala del arreglo
                if (bicicletaAEliminar != null)
                {
                    arregloBicicletas = arregloBicicletas.Where(b => b != bicicletaAEliminar).ToArray();

                    // Actualiza el DataGridView después de eliminar
                    ActualizarDataGridView();
                }
                else
                {
                    MessageBox.Show($"No se encontró una bicicleta con ID {id}.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("El arreglo de bicicletas no está inicializado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void agregarBici_Click(object sender, EventArgs e)
        {
            AgregarBici agregarBici = new AgregarBici(this); // Pasa la instancia actual a la nueva ventana
            this.Hide();
            agregarBici.Show();
        }

        private void volverButton_Click(object sender, EventArgs e)
        {
            Inicio form = new Inicio();
            this.Close();
            form.ShowDialog();
        }
        
        public int ObtenerUltimoID()
        {
            if (arregloBicicletas != null && arregloBicicletas.Length > 0)
            {
                // Utiliza LINQ para obtener el máximo ID en el arreglo
                return arregloBicicletas.Max(b => b?.Id ?? 0);
            }
            else
            {
                return 0; // Si el arreglo está vacío, devuelve 0 como ID inicial
            }
        }

        private void eliminarBiciA_Click(object sender, EventArgs e)
        {
           
            EliminarBiciArreglo eliminarBici = new EliminarBiciArreglo();
            this.Hide();
            eliminarBici.Show();
        }

        private void editarBiciA_Click(object sender, EventArgs e)
        {
           /* Bicicletas bicicletaSeleccionada;
            CatalogoArreglo catalogo = new CatalogoArreglo();
            EditarBiciArreglos agregarBici = new EditarBiciArreglos(catalogo, bicicletaSeleccionada);
            this.Hide();
            agregarBici.Show();*/
        }
    }
}
