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
        public CatalogoArreglo()
        {
            InitializeComponent();
            AgregarBicisAuto();
        }

        private void AgregarBicisAuto()
        {
            // Crear un arreglo de objetos de tipo Bicicletas
            Bicicletas[] arregloBicicletas = new Bicicletas[3]; // Puedes ajustar el tamaño según tus necesidades

            // Llenar el arreglo con datos
            arregloBicicletas[0] = new Bicicletas { Id = 1, Nombre = "V10", Tamaño = "M", Talla = "29\"" };
            arregloBicicletas[1] = new Bicicletas { Id = 2, Nombre = "Megatower", Tamaño = "XL", Talla = "29\"" };
            arregloBicicletas[2] = new Bicicletas { Id = 3, Nombre = "Bullit", Tamaño = "L", Talla = "27\"" };

            // Configurar el DataGridView
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = arregloBicicletas;
        }

        private void agregarBici_Click(object sender, EventArgs e)
        {
            AgregarBici agregarBici = new AgregarBici();
            agregarBici.Show();
        }

        private void volverButton_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Close();
            form.ShowDialog();
        }
    }
}
