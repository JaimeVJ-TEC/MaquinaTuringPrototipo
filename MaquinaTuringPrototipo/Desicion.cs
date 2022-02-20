using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaTuringPrototipo
{
    public class Decision
    {
        private int _intOperacionOrig;

        public int OperacionOrig
        {
            get { return _intOperacionOrig; }
            set { _intOperacionOrig = value; }
        }

        private int _intOperacionDestino;

        public int OperacionDestino
        {
            get { return _intOperacionDestino; }
            set { _intOperacionDestino = value; }
        }

        private char _chrCondicion;

        public char Condicion
        {
            get { return _chrCondicion; }
            set { _chrCondicion = value; }
        }

        private bool _blnNegacion;

        public bool Negacion
        {
            get { return _blnNegacion; }
            set { _blnNegacion = value; }
        }


    }
}
