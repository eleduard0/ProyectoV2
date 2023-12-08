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
        CatalogoArreglo catalogo;
        public OrdenandoMensaje(CatalogoArreglo catalogo)
        {
            InitializeComponent();
            this.catalogo = catalogo;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            catalogo.Show();
            this.Hide();

        }
    }
}
