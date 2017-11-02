using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeTuring
{

    public enum Simbolos { INICIAL, ASTERISCO, BRANCO, AUXILIAR };
    public enum Estados { _0, _1, _2, _3, _4, _5, _6, _7, _8, _9, _10};
    public enum Direcao { DIREITA, ESQUERDA };

    class Table
    {
        private Estados estado { get { return estado; } set { estado = value; } }
        private Simbolos simbolo { get { return simbolo; } set { simbolo = value; } }
        private Estados vaiParaEstado { get { return vaiParaEstado; } set { vaiParaEstado = value; } }
        private Simbolos escreveSimbolo { get { return escreveSimbolo; } set { escreveSimbolo = value; } }
        private Direcao direcao { get { return direcao; } set { direcao = value; } }
        
        public Table(Estados estado, Simbolos simbolo, Estados vaiPara, Simbolos escreveSimbolo, Direcao direcao)
        {
            this.estado = estado;
            this.simbolo = simbolo;
            this.vaiParaEstado = vaiPara;
            this.escreveSimbolo = escreveSimbolo;
            this.direcao = direcao;
        }
    }
}
