using ProyectoV2.BackendArreglos;
using ProyectoV2.Vistas;
using ProyectoV2.Vistas.VistasPilas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ProyectoV2.Vistas.VistasArreglo;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoV2.Vistas.VistasColas;

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
            //Arreglos arreglos = new Arreglos(); 
            //CatalogoArreglo catalogoArreglo = new CatalogoArreglo(arreglos);
            //catalogoArreglo.Show();
            //this.Hide();

            VistaLongitud vistaLongitud = new VistaLongitud();
            vistaLongitud.Show();
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

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void IrPilas_Click(object sender, EventArgs e)
        {
            TamañoPilas catalogoPilas = new TamañoPilas();
            catalogoPilas.Show();
            this.Hide();
        }

        private void IrColas_Click(object sender, EventArgs e)
        {
            TamañoColas catalogoColas = new TamañoColas();
            catalogoColas.Show();
            this.Hide();
        }
    }
}
