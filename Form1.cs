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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CatalogoArreglo catalogoArreglo = new CatalogoArreglo();
            catalogoArreglo.Show();

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.Control;
        }
    }
}
