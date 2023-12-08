using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoV2.BackendListas
{
    public class Nodo
    {
        private Bicicletas Bicicleta;
        private Nodo Siguiente;

        public Bicicletas _Bicicleta;
        public Nodo _Siguiente;

        public Nodo(Bicicletas bici)
        {
            _Bicicleta = bici;
            _Siguiente = null;

        } 

    }
}
