using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoV2.Vistas.VistasArreglo
{
    public partial class OrdenandoMensaje : Form
    {
        CatalogoArreglo catalogoxd;
        public OrdenandoMensaje(CatalogoArreglo catalogo)
        {
            InitializeComponent();
            catalogoxd = catalogo;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            catalogoxd.Show();
            this.Hide();
           
        }

        private void OrdenandoMensaje_Load(object sender, EventArgs e)
        {

        }
    }
}
