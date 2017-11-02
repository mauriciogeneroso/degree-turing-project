using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeTuring
{

    public enum Simbolos { INICIAL = '>', ASTERISCO = '*', BRANCO = '_', AUXILIAR = 'A'};
    public enum Estados { _0, _1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _FINAL};
    public enum Direcao { DIREITA, ESQUERDA };

    class TabelaItens
    {
        private Estados estado;
        private Simbolos simbolo;
        private Estados vaiParaEstado;
        private Simbolos escreveSimbolo;
        private Direcao direcao;

        public Estados Estado { get { return estado; } set { estado = value; } }
        public Simbolos Simbolo { get { return simbolo; } set { simbolo = value; } }
        public Estados VaiParaEstado { get { return vaiParaEstado; } set { vaiParaEstado = value; } }
        public Simbolos EscreveSimbolo { get { return escreveSimbolo; } set { escreveSimbolo = value; } }
        public Direcao Direcao { get { return direcao; } set { direcao = value; } }

        public TabelaItens(Estados estado, Simbolos simbolo, Estados vaiPara, Simbolos escreveSimbolo, Direcao direcao)
        {
            this.Estado = estado;
            this.Simbolo = simbolo;
            this.VaiParaEstado = vaiPara;
            this.EscreveSimbolo = escreveSimbolo;
            this.Direcao = direcao;
        }


    }
}
