using ProyectoV2.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoV2.BackendArreglos
{
    public class Arreglos
    {
        Bicicletas bicicletaxd;

        Bicicletas[] arreglobicis;
        Bicicletas[] arregloAuxiliar;

        int cantidadBicis;

        int Longitud;
        int id = 0;
        public Arreglos(int longitud = 10)
        {
            Longitud = longitud;
            arreglobicis = new Bicicletas[Longitud];
            arregloAuxiliar = new Bicicletas[Longitud];
        }

        public bool ArregloVacio()
        {
            return cantidadBicis == 0;
        }

        public Bicicletas[] ObtenerArregloBicicletas()
        {
            return arreglobicis;
        }


        public Bicicletas[] AgregarBicisAlInicio(Bicicletas bicixd)
        {
            if (!ArregloLleno())
            {
                for (int i = arreglobicis.Length - 1; i >= 0; i--)
                {
                    if (arreglobicis[i] == null)
                    {
                        continue;
                    }
                    arreglobicis[i + 1] = arreglobicis[i];
                }
                arreglobicis[0] = bicixd;
                cantidadBicis++;
                return arreglobicis;
            }
            return null;
        }

        public Bicicletas[] AgregarBicisAlMedio(Bicicletas bicixd)
        {
            if (!ArregloLleno())
            {
                int posicion = cantidadBicis / 2; 
                for (int i = arreglobicis.Length - 1; i > posicion; i--)
                {
                    if (arreglobicis[i - 1] != null)
                    {
                        arreglobicis[i] = arreglobicis[i - 1];
                    }
                }
                arreglobicis[posicion] = bicixd;
                cantidadBicis++;
                return arreglobicis;
            }
            return null;
        }


        public Bicicletas[] AgregarBicis(Bicicletas bicixd)
        {
            if (cantidadBicis < arreglobicis.Length)
            {
                for (int i = 0; i < arreglobicis.Length; i++)
                {
                    if (arreglobicis[i] == null)
                    {
                        arreglobicis[i] = bicixd;
                        cantidadBicis++;
                        break;
                    }


                }

                return arreglobicis;
            }
            else
            {

                return null;
            }
        }

        public bool ArregloLleno()
        {
            return cantidadBicis < arreglobicis.Length ? false : true;
        }




        public int ObtenerUltimoID()
        {
            if (arreglobicis != null && arreglobicis.Length > 0)
            {

                return arreglobicis.Max(b => b?.Id ?? 0);
            }
            else
            {
                return 0;
            }
        }

        public void EditarBicicleta(Bicicletas bicicleta)
        {
            for (int i = 0; i < arreglobicis.Length; i++)
            {
                if (arreglobicis[i].Id == bicicleta.Id)
                {
                    arreglobicis[i] = bicicleta;
                    break;
                }
            }
        }

        public void EliminarBicicleta(int idBicicleta)
        {
            if (ArregloVacio())
            {
                return;
            }
            for (int i = 0; i < arreglobicis.Length; i++)
            {
                if (arreglobicis[i].Id == idBicicleta)
                {
                    arreglobicis[i] = null;
                    cantidadBicis--;
                    break;
                }
            }
        }


        //////////////////////////////////////////////////////////////////////////

        public Bicicletas[] OrdenarAscendente()
        {
            for (int i = 0; i < cantidadBicis - 1; i++)
            {
                for (int j = 0; j < cantidadBicis - i - 1; j++)
                {
                    if (arreglobicis[j].Talla > arreglobicis[j + 1].Talla)
                    {
                        
                        Bicicletas temp = arreglobicis[j];
                        arreglobicis[j] = arreglobicis[j + 1];
                        arreglobicis[j + 1] = temp;
                    }
                }
            }
            return arreglobicis;
        }

        public Bicicletas[] OrdenarDescendente()
        {
            for (int i = 0; i < cantidadBicis - 1; i++)
            {
                for (int j = 0; j < cantidadBicis - i - 1; j++)
                {
                    if (arreglobicis[j].Talla < arreglobicis[j + 1].Talla)
                    {
                        
                        Bicicletas temp = arreglobicis[j];
                        arreglobicis[j] = arreglobicis[j + 1];
                        arreglobicis[j + 1] = temp;
                    }
                }
            }
            return arreglobicis;
        }




        public Bicicletas[] Buscar(string nombre)
        {
            if (ArregloVacio())
            {
                return null;
            }
            for (int i = 0; i < cantidadBicis; i++)
            {
                if (arreglobicis[i].Nombre == nombre)
                {
                    arregloAuxiliar[i] = arreglobicis[i];

                }

            }

            return arregloAuxiliar;

        }





    }
}
