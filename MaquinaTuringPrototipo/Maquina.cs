using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaTuringPrototipo
{
    public class Maquina
    {
        public Cinta Cinta = new Cinta();

        public List<Operacion> Operaciones = new List<Operacion>();

        public int OperacionActual = 0;

        public void EjecutarOperacion()
        {
            Operacion Op = Operaciones[OperacionActual];

            switch(Op.Tipo)
            {
                case "Movimiento":
                    Cinta.Movimiento(Op.Derecha);
                    break;

                case "Busqueda":
                    Cinta.Buscar(Op.Derecha, Op.Simbolo);
                    break;

                case "Sobreescribir":
                    Cinta.Sobreescribir(Op.Simbolo);
                    break;

                case "Guardar":
                    Cinta.Guardar();
                    break;

                case "N":
                    Cinta.Nada();
                    break;
            }

            if(Op.Decisiones.Count > 0)
            {
                int a = Op.Decisiones.Count -1;

                for (int i = 0; i <= a; i++)
                {
                    if (Cinta._Cadena[Cinta.PosicionActual] == Op.Decisiones[i].Condicion)
                    {
                        OperacionActual = Op.Decisiones[i].OperacionDestino;
                    }
                }
            }
            else
            {
                OperacionActual++;
            }

            //throw new Exception("Fin");
        }
    }
}
