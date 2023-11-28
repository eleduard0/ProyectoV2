using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoV2.Vistas
{
    public partial class EliminarBiciArreglo : Form
    {
        private CatalogoArreglo catalogoArreglo;

        public EliminarBiciArreglo()
        {
            InitializeComponent();
            catalogoArreglo = new CatalogoArreglo();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int idAEliminar = ObtenerIdBicicletaAEliminar(); // Puedes obtener el ID de alguna manera
                catalogoArreglo.EliminarBicicleta(idAEliminar);
                MessageBox.Show("Bicicleta eliminada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar eliminar la bicicleta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
            catalogoArreglo.ShowDialog();
        }

        private int ObtenerIdBicicletaAEliminar()
        {
            // Puedes implementar la lógica para obtener el ID de la bicicleta a eliminar
            // Puede ser desde un TextBox, ComboBox, etc.
            // En este ejemplo, asumo que tienes un TextBox llamado txtIdBicicleta
            
            
                return int.Parse(txtIdBicicleta.Text);
            
           
        }
    }
}
