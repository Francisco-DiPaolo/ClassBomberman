using System;
using System.Collections.Generic;
using System.Text;

namespace Bomberman
{
    class Player
    {
        public float velocidad;

        public int rango;
        public int tiempo;

        public int cantidadBombas;
        public int bombasMax;

        public void Mover()
        {
            //Input del jugador.
        }

        public void UsarBombas(float tiempo, int rango)
        {
            //Usar bombas unicamente si es mayor a 0, con su rango y tiempo. y restar la bomba.
        }

        public void RespawnBombas()
        {
            //Luego de un tiempo se suma una bomba.
        }

        public void RecibirDaño()
        {
            //Destruir jugador
        }

        public void RecogerUpgrates(int tipo)
        {
            //Agarrar determinado objeto y aumentar el valor del mismo (a traves de un switch).
        }
    }
}
