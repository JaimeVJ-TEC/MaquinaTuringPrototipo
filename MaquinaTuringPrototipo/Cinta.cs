using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaTuringPrototipo
{
    /*
     * La clase Cinta maneja el alfabeto y cadena de la maquina de turing ademas de la memoria para guardar un simbolo.
     * Tambiene tiene los metodos correspondientes a las operaciones de maquinas compuestas para manipular la cadena y el cabezal.
     */
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
            {
                PosicionActual = 0;
                throw new Exception("Terminacion abnormal");
            }
            else if (PosicionActual >= _Cadena.Count)
            {
                _Cadena.Add('Δ');
            }
        }

        //Operacion de busqueda a derecha o izquierda
        public bool Buscar(bool Derecha, char Simbolo, bool Not)
        {
            if (Simbolo == 'Δ' || Simbolo == '#' || Alfabeto.Contains(Simbolo))
            {
                bool Parada = false;

                if (Derecha)
                {
                    Movimiento(true);
                    if (Not)
                    {
                        for (int i = PosicionActual; i < _Cadena.Count; i++)
                        {
                            if (_Cadena[i] != Simbolo)
                            {
                                Parada = false;
                                break;
                            }
                            else
                                Parada = true;
                        }

                        if (Parada)
                        {
                            PosicionActual = PosiciconInicial;
                            throw new Exception("Problema de parada");
                        }

                        if (_Cadena[PosicionActual] != Simbolo)
                            return true;
                        else
                            return false;
                    }
                    else
                    {
                        if (Simbolo != 'Δ')
                        {
                            for (int i = PosicionActual; i < _Cadena.Count; i++)
                            {
                                if (_Cadena[i] == Simbolo)
                                {
                                    Parada = false;
                                    break;
                                }
                                else
                                    Parada = true;
                            }
                            if (Parada)
                            {
                                PosicionActual = PosiciconInicial;
                                throw new Exception("Problema de parada");
                            }
                        }

                        if (_Cadena[PosicionActual] == Simbolo)
                            return true;
                        else
                            return false;
                    }
                }
                else
                {
                    Movimiento(false);
                    if (Not)
                    {
                        if (_Cadena[PosicionActual] != Simbolo)
                            return true;
                        else
                            return false;
                    }
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
