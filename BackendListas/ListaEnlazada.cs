using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoV2.BackendListas
{
    public class ListaEnlazada
    {
        Nodo primerNodo;

        public bool ListaVacia()
        {
            return primerNodo == null ? true : false;
        }

        public int ObtenerUltimoID()
        {
            if (primerNodo == null)
            {
                return 0;
            }

            Nodo nodoActual = primerNodo;

            while (nodoActual._Siguiente != null)
            {
                nodoActual = nodoActual._Siguiente;
            }

            return nodoActual._Bicicleta?.Id ?? 0;
        }

        public Nodo ObtenerNodoPorId(int id)
        {
            Nodo nodoActual = primerNodo;

            while (nodoActual != null && nodoActual._Bicicleta.Id != id)
            {
                nodoActual = nodoActual._Siguiente;
            }

            return nodoActual;
        }




        public Bicicletas[] ObtenerListaEnlazadaBicicletas()
        {
            int contador = ContarNodos();
            Bicicletas[] arregloBicicletas = new Bicicletas[contador];

            Nodo nodoActual = primerNodo;

            for (int i = 0; i < contador; i++)
            {
                arregloBicicletas[i] = nodoActual._Bicicleta;
                nodoActual = nodoActual._Siguiente;
            }

            return arregloBicicletas;
        }
        public Bicicletas[] Buscar(string nombre)
        {
            if (ListaVacia())
            {
                return null;
            }

            int contador = ContarNodos();
            Bicicletas[] arregloBicicletas = new Bicicletas[contador];
            int contadorCoincidencias = 0;

            Nodo nodoActual = primerNodo;

            for (int i = 0; i < contador; i++)
            {
                arregloBicicletas[i] = nodoActual._Bicicleta;
                nodoActual = nodoActual._Siguiente;

                if (arregloBicicletas[i].Nombre == nombre)
                {
                    contadorCoincidencias++;
                }
            }

            Bicicletas[] arregloAuxiliar = new Bicicletas[contadorCoincidencias];
            int buscados = 0;

            for (int i = 0; i < contador; i++)
            {
                if (arregloBicicletas[i].Nombre == nombre)
                {
                    arregloAuxiliar[buscados++] = arregloBicicletas[i];
                }
            }

            return arregloAuxiliar;
        }


        private int ContarNodos()
        {
            int contador = 0;
            Nodo nodoActual = primerNodo;

            while (nodoActual != null)
            {
                contador++;
                nodoActual = nodoActual._Siguiente;
            }

            return contador;
        }

        public void AgregarAlInicio(Bicicletas bicicleta)
        {
            Nodo nuevoNodo = new Nodo(bicicleta);
            nuevoNodo._Siguiente = primerNodo;
            primerNodo = nuevoNodo;

        }



        public void AgregarAlMedio(Bicicletas bicicleta)
        {
            Nodo nuevoNodo = new Nodo(bicicleta);

            if (primerNodo == null)
            {

                AgregarAlInicio(bicicleta);
                return;
            }

            Nodo nodoRapido = primerNodo;
            Nodo nodoLento = primerNodo;
            Nodo nodoAnterior = null;

            while (nodoRapido != null && nodoRapido._Siguiente != null)
            {
                nodoRapido = nodoRapido._Siguiente?._Siguiente;
                nodoAnterior = nodoLento;
                nodoLento = nodoLento._Siguiente;
            }


            nuevoNodo._Siguiente = nodoLento;

            if (nodoAnterior != null)
            {
                nodoAnterior._Siguiente = nuevoNodo;
            }
            else
            {
                primerNodo = nuevoNodo;
            }
        }


        public void AgregarAlFinal(Bicicletas bicicleta)
        {
            Nodo nuevoNodo = new Nodo(bicicleta);
            if (ListaVacia())
            {
                primerNodo = nuevoNodo;
                return;
            }
            else
            {
                Nodo nodoActual = primerNodo;
                while (nodoActual._Siguiente != null)
                {
                    nodoActual = nodoActual._Siguiente;

                }
                nodoActual._Siguiente = nuevoNodo;
            }
        }
        public void Eliminar(Bicicletas bicicleta)
        {
            if (ListaVacia())
            {
                return;
            }

            Nodo nodoActual = primerNodo;
            Nodo nodoAnterior = null;
            if (nodoActual._Bicicleta == bicicleta)
            {
                primerNodo = primerNodo._Siguiente;
                return;
            }

            while (nodoActual != null && nodoActual._Bicicleta != bicicleta)
            {
                nodoAnterior = nodoActual;
                nodoActual = nodoActual._Siguiente;
            }

            if (nodoActual == null)
            {
                Console.WriteLine("No existe esa bicicleta a eliminar!");
                return;

            }
            nodoAnterior._Siguiente = nodoActual._Siguiente;

        }
        public void OrdenarAscendente()
        {
            bool intercambio;

            do
            {
                intercambio = false;

                Nodo nodoActual = primerNodo;
                Nodo nodoSiguiente = primerNodo?._Siguiente;

                while (nodoSiguiente != null)
                {
                    if (nodoActual._Bicicleta.Talla > nodoSiguiente._Bicicleta.Talla)
                    {

                        Bicicletas tempBicicleta = nodoActual._Bicicleta;
                        nodoActual._Bicicleta = nodoSiguiente._Bicicleta;
                        nodoSiguiente._Bicicleta = tempBicicleta;

                        intercambio = true;
                    }

                    nodoActual = nodoSiguiente;
                    nodoSiguiente = nodoSiguiente._Siguiente;
                }

            } while (intercambio);
        }

        public void OrdenarDescendente()
        {
            bool intercambio;

            do
            {
                intercambio = false;

                Nodo nodoActual = primerNodo;
                Nodo nodoSiguiente = primerNodo?._Siguiente;

                while (nodoSiguiente != null)
                {
                    if (nodoActual._Bicicleta.Talla < nodoSiguiente._Bicicleta.Talla)
                    {

                        Bicicletas tempBicicleta = nodoActual._Bicicleta;
                        nodoActual._Bicicleta = nodoSiguiente._Bicicleta;
                        nodoSiguiente._Bicicleta = tempBicicleta;

                        intercambio = true;
                    }

                    nodoActual = nodoSiguiente;
                    nodoSiguiente = nodoSiguiente._Siguiente;
                }

            } while (intercambio);
        }

        public void EditarBicicleta(Bicicletas bicicleta)
        {
            if (bicicleta == null)
            {
                return;
            }

            Nodo nodoActual = primerNodo;

            while (nodoActual != null && nodoActual._Bicicleta != bicicleta)
            {
                nodoActual = nodoActual._Siguiente;
            }

            if (nodoActual == null)
            {
                Console.WriteLine("No existe esa bicicleta a editar!");
                return;
            }

            
            nodoActual._Bicicleta.Nombre = bicicleta.Nombre;
            nodoActual._Bicicleta.Talla = bicicleta.Talla;
            nodoActual._Bicicleta.Tamaño = bicicleta.Tamaño;
        }







    }
}
