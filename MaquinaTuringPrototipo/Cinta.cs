using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaTuringPrototipo
{
    public class Cinta
    {
        public List<char> Alfabeto = new List<char>();

        public List<char> _Cadena = new List<char>();

        char Memoria;

        private int _intPosicionInicial;

        public int PosiciconInicial
        {
            get { return _intPosicionInicial; }
            set { _intPosicionInicial = value;
                _intPosicionActual = value; }
        }

        private int _intPosicionActual;

        public int PosicionActual
        {
            get { return _intPosicionActual; }
            set { _intPosicionActual = value; }
        }

        public void AgregarCadena(char Simbolo)
        {
            if (Simbolo == 'Δ' || Simbolo == '#')
                _Cadena.Add(Simbolo);
            else if (Alfabeto.Contains(Simbolo))
                _Cadena.Add(Simbolo);
            else
                throw new Exception("Simbolo no pertenece al alfabeto");
        }

        //Operacion de Movimiento a derecha o izquierda
        public void Movimiento(bool Derecha)
        {
            if (Derecha)
                PosicionActual++;
            else
                PosicionActual--;

            if (PosicionActual == -1)
                throw new Exception("Terminacion abnormal");
            else if (PosicionActual >= _Cadena.Count)
                throw new Exception("Fin de la cadena");
        }

        //Operacion de busqueda a derecha o izquierda
        public bool Buscar(bool Derecha, char Simbolo, bool Not)
        {
            if (Simbolo == 'Δ' || Simbolo == '#' || Alfabeto.Contains(Simbolo))
            {
                if (Derecha)
                {
                    Movimiento(true);
                    if (Not)
                        if (_Cadena[PosicionActual] != Simbolo)
                            return true;
                        else
                            return false;
                    else if (_Cadena[PosicionActual] == Simbolo)
                        return true;
                    else
                        return false;
                }
                else
                {
                    Movimiento(false);
                    if(Not)
                        if (_Cadena[PosicionActual] != Simbolo)
                            return true;
                        else
                            return false;
                    else if (_Cadena[PosicionActual] == Simbolo)
                        return true;
                    else
                        return false;
                }
            }
            else
                throw new Exception("Simbolo no valido");
        }

        //Operacion de Sobreescritura un simbolo con otro
        public void Sobreescribir(char Simbolo)
        {
            if(Simbolo == 'σ')
            {
                try
                {
                    _Cadena[PosicionActual] = Memoria;
                }
                catch(Exception) { }
            }
            else if (Simbolo == 'Δ' || Simbolo == '#' || Alfabeto.Contains(Simbolo))
            {
                _Cadena[PosicionActual] = Simbolo;
            }
            else
                throw new Exception("Simbolo no valido");
        }

        //Operacion de guardar un simbolo en memoria
        public void Guardar()
        {
            Memoria = _Cadena[PosicionActual];
        }

        //Operacion N
        public void Nada()
        {
            return;
        }
    }
}
