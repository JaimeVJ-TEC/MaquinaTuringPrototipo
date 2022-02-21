using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaTuringPrototipo
{
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
