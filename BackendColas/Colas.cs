﻿using System;

namespace ProyectoV2.BackendCola
{
    public class Colas
    {
        private const string ColaLlenaMensaje = "Cola llena";
        private const string ColaVaciaMensaje = "Cola vacía";

        private int CantidadBicis { get; set; }
        public int TamañoMaximo { get; }
        private Bicicletas[] Bicicletas { get; }
        private int Frente { get; set; }
        private int Posterior { get; set; }

        public Colas(int tamañoMaximo)
        {
            this.TamañoMaximo = tamañoMaximo;
            this.Bicicletas = new Bicicletas[tamañoMaximo];
            this.Frente = 0;
            this.Posterior = -1;
        }

        public bool EstaLlena() => CantidadBicis == TamañoMaximo;

        public void Insertar(Bicicletas bicicleta)
        {
            if (EstaLlena())
            {
                throw new InvalidOperationException(ColaLlenaMensaje);
            }

            Posterior = (Posterior + 1) % TamañoMaximo;
            Bicicletas[Posterior] = bicicleta;
            CantidadBicis++;
        }

        public Bicicletas[] ObtenerArregloBicicletas()
        {
            Bicicletas[] arreglo = new Bicicletas[CantidadBicis];
            int indice = 0;
            int i = Frente;

            while (indice < CantidadBicis)
            {
                arreglo[indice++] = Bicicletas[i];
                i = (i + 1) % TamañoMaximo;
            }

            return arreglo;
        }

        public int ObtenerUltimoID()
        {
            if (CantidadBicis > 0)
            {
                int indiceUltimo = (Posterior - 1 + TamañoMaximo) % TamañoMaximo;
                return Bicicletas[indiceUltimo]?.Id ?? 0;
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
                throw new InvalidOperationException(ColaLlenaMensaje);
            }
        }

        public void EliminarBicicleta(int id)
        {
            Bicicletas[] colaAuxiliar = new Bicicletas[TamañoMaximo];
            int indiceAuxiliar = 0;

            while (CantidadBicis > 0)
            {
                Bicicletas bicicletaActual = Bicicletas[Frente];
                Frente = (Frente + 1) % TamañoMaximo;
                CantidadBicis--;

                if (bicicletaActual.Id != id)
                {
                    colaAuxiliar[indiceAuxiliar++] = bicicletaActual;
                }
            }

            foreach (var bici in colaAuxiliar)
            {
                if (bici != null)
                {
                    Insertar(bici);
                }
            }
        }

        public void EditarBicicleta(int id, Bicicletas nuevaBicicleta)
        {
            Bicicletas[] colaAuxiliar = new Bicicletas[TamañoMaximo];
            int indiceAuxiliar = 0;

            while (CantidadBicis > 0)
            {
                Bicicletas bicicletaActual = Bicicletas[Frente];
                Frente = (Frente + 1) % TamañoMaximo;
                CantidadBicis--;

                if (bicicletaActual.Id == id)
                {
                    colaAuxiliar[indiceAuxiliar++] = nuevaBicicleta;
                }
                else
                {
                    colaAuxiliar[indiceAuxiliar++] = bicicletaActual;
                }
            }

            foreach (var bici in colaAuxiliar)
            {
                if (bici != null)
                {
                    Insertar(bici);
                }
            }
        }
    }
}