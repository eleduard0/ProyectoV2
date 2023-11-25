using System;
using System.Windows.Forms;
using System.Linq; // Agrega esta referencia para usar ToList()

namespace ProyectoV2.Vistas
{
    public partial class CatalogoListas : Form
    {
        public CatalogoListas()
        {
            InitializeComponent();
            AgregarBicisAuto();
        }

        public class Nodo
        {
            private Nodo _siguiente;
            private Bicicletas _datosBici;
            public Nodo Siguiente;
            public Bicicletas DatosBici;

            public Nodo(Bicicletas bici)
            {
                DatosBici = bici;
                Siguiente = null;
            }
        }

        public class Lista
        {
            Nodo inicio;
            public bool ListaVacia()
            {
                return inicio == null;
            }

            public void Insertar(Bicicletas bicicletas)
            {
                Nodo nuevoNodo = new Nodo(bicicletas);
                if (ListaVacia())
                {
                    inicio = nuevoNodo;
                }
                else
                {
                    Nodo actual = inicio;
                    while (actual.Siguiente != null)
                    {
                        actual = actual.Siguiente;
                    }
                    actual.Siguiente = nuevoNodo;
                }
            }

            // Agrega un método para convertir la lista en IEnumerable
            public System.Collections.Generic.IEnumerable<Bicicletas> ObtenerBicicletas()
            {
                Nodo actual = inicio;
                while (actual != null)
                {
                    yield return actual.DatosBici;
                    actual = actual.Siguiente;
                }
            }
        }

        public void AgregarBicisAuto()
        {
            Lista lista = new Lista();
            lista.Insertar(new Bicicletas { Id = 1, Nombre = "V10", Tamaño = "M", Talla = "29\"" });
            lista.Insertar(new Bicicletas { Id = 2, Nombre = "Megatower", Tamaño = "XL", Talla = "29\"" });
            lista.Insertar(new Bicicletas { Id = 3, Nombre = "Bullit", Tamaño = "L", Talla = "27\"" });

            // Convierte la lista en IEnumerable utilizando el método ObtenerBicicletas
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = lista.ObtenerBicicletas().ToList();
        }
      

        private void volverButton_Click_1(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Close();
            form.ShowDialog();
        }
    }
}
