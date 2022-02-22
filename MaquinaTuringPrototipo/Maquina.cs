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
            if (OperacionActual == Operaciones.Count)
            {
                throw new Exception("Fin");
            }

            Operacion Op = Operaciones[OperacionActual];
            bool resultado =true;

            switch(Op.Tipo)
            {
                case "Movimiento":
                    Cinta.Movimiento(Op.Derecha);
                    break;

                case "Busqueda":
                    resultado = Cinta.Buscar(Op.Derecha, Op.Simbolo,Op.Negacion);
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


            //Si la operacion tiene decisiones (aristas) entonces en vez de aumentar 1 a OperacionActual se evalua la condicion
            if(Op.Decisiones.Count > 0)
            {
                int a = Op.Decisiones.Count -1;

                for (int i = 0; i <= a; i++)
                {
                    if (Op.Decisiones[i].Condicion == '\0')
                    {
                        OperacionActual = Op.Decisiones[i].OperacionDestino;
                        return;
                    }

                    if (!Op.Decisiones[i].Negacion)
                    {
                        if (Cinta._Cadena[Cinta.PosicionActual] == Op.Decisiones[i].Condicion)
                        {
                            OperacionActual = Op.Decisiones[i].OperacionDestino;
                            return;
                        }
                    }
                    else if (Cinta._Cadena[Cinta.PosicionActual] != Op.Decisiones[i].Condicion)
                    {
                        OperacionActual = Op.Decisiones[i].OperacionDestino;
                        return;
                    }
                }
                throw new Exception("Fin");

            }
            else if(Op.Tipo == "Busqueda" && resultado == false)
            {
                
            }
            else
            {
                OperacionActual++;
            }
        }
    }
}