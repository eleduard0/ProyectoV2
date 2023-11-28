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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void IrArreglos_Click(object sender, EventArgs e)
        {
            CatalogoArreglo catalogoArreglo = new CatalogoArreglo();
            catalogoArreglo.Show();
            this.Hide();

        }
        

        /*private void button1_MouseHover(object sender, EventArgs e)
        {
            IrArreglos.BackColor = SystemColors.Control;
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            CatalogoListas catalogoListas = new CatalogoListas();
            catalogoListas.Show();
            this.Hide();
        }
    }
}
