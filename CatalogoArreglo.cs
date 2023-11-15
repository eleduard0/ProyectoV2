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
            // Configurar las columnas del DataGridView
            dataGridView1.Columns.Add("BicicletaColumn", "Bicicleta");

            // Poblar el catálogo de bicicletas con datos predefinidos.
            string[] bicicletas = { "High Tower", "SantaCruz", "Eleduardo" };

            // Asegúrate de que el nombre del DataGridView sea correcto.
            dataGridView1.Rows.Clear(); // Limpiar las filas por si acaso
            foreach (var bicicleta in bicicletas)
            {
                dataGridView1.Rows.Add(bicicleta);
            }
        }
    }
}
