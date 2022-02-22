using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaTuringPrototipo
{
    /*
     * La clase Operacion representa las operaciones de las maquinas compuestas, con sus propiedades, las operaciones son ejecutadas en
     * la clase de Maquina haciendo uso de los metodos de la clase Cinta, ademas cada operacion tiene una lista de decisiones que pueden
     * el orden en que son ejecutadas.
     */
    public class Operacion
    {
        private string _strTipo;

        public string Tipo
        {
            get { return _strTipo; }
            set { _strTipo = value; }
        }

        private char _chrSimbolo;

        public char Simbolo
        {
            get { return _chrSimbolo; }
            set { _chrSimbolo = value; }
        }

        private bool _blnDerecha;

        public bool Derecha
        {
            get { return _blnDerecha; }
            set { _blnDerecha = value; }
        }

        private bool _blnNegacion;

        public bool Negacion
        {
            get { return _blnNegacion; }
            set { _blnNegacion = value; }
        }

        public List<Decision> Decisiones = new List<Decision>();
    }
}
