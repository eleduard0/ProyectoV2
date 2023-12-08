using System;
using System.Linq;

namespace ProyectoV2.BackendPila
{
    public class Pilas
    {
        private const string PilaLlenaMensaje = "Pila llena";
        private const string PilaVaciaMensaje = "Pila vacía";

        private int CantidadBicis { get; set; }
        public int TamañoMaximo { get; }
        private int Cabeza { get; set; }
        private Bicicletas[] BicicletasArray { get; }

        public Pilas(int tamañoMaximo)
        {
            this.TamañoMaximo = tamañoMaximo;
            this.Cabeza = -1;
            this.BicicletasArray = new Bicicletas[tamañoMaximo];
        }

        public bool EstaLlena() => Cabeza == TamañoMaximo - 1;

        public void Insertar(Bicicletas bicicleta)
        {
            if (EstaLlena())
            {
                throw new InvalidOperationException(PilaLlenaMensaje);
            }

            Cabeza++;
            BicicletasArray[Cabeza] = bicicleta;
        }

        public Bicicletas Extraer()
        {
            if (Cabeza == -1)
            {
                throw new InvalidOperationException(PilaVaciaMensaje);
            }

            Bicicletas bicicletaExtraida = BicicletasArray[Cabeza];
            Cabeza--;
            return bicicletaExtraida;
        }

        public Bicicletas[] ObtenerArregloBicicletas() => BicicletasArray;

        public int ObtenerUltimoID()
        {
            if (BicicletasArray != null && BicicletasArray.Length > 0)
            {
                return BicicletasArray.Max(b => b?.Id ?? 0);
            }
            else
            {
                return 0;
            }
        }

        public void AgregarBicicleta(Bicicletas bici)
        {
            if (!EstaLlena())
            {
                bici.Id = ++CantidadBicis;
                Insertar(bici);
            }
            else
            {
                throw new InvalidOperationException(PilaLlenaMensaje);
            }
        }

        public void EliminarBicicleta(int id)
        {
            
            Bicicletas[] pilaAuxiliar = new Bicicletas[TamañoMaximo];
            int indiceAuxiliar = 0;

            while (Cabeza >= 0)
            {
                Bicicletas bicicletaActual = Extraer();
                if (bicicletaActual.Id != id)
                {
                    pilaAuxiliar[indiceAuxiliar++] = bicicletaActual;
                }
            }

            for (int i = indiceAuxiliar - 1; i >= 0; i--)
            {
                Insertar(pilaAuxiliar[i]);
            }
        }

        public void EditarBicicleta(int id, Bicicletas nuevaBicicleta)
        {
            Bicicletas[] pilaAuxiliar = new Bicicletas[TamañoMaximo];
            int indiceAuxiliar = 0;

            while (Cabeza >= 0)
            {
                Bicicletas bicicletaActual = Extraer();
                if (bicicletaActual.Id == id)
                {
                    pilaAuxiliar[indiceAuxiliar++] = nuevaBicicleta;
                }
                else
                {
                    pilaAuxiliar[indiceAuxiliar++] = bicicletaActual;
                }
            }

            for (int i = indiceAuxiliar - 1; i >= 0; i--)
            {
                Insertar(pilaAuxiliar[i]);
            }
        }
    }
}
