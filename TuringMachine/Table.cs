using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeTuring
{
    class Table
    {
        MaquinaDeTuring.Simbolos simbolo { get { return simbolo; } set { simbolo = value; } }
        MaquinaDeTuring.Direcao direcao { get { return direcao; } set { direcao = value; } }
        MaquinaDeTuring.Estados estado { get { return estado; } set { estado = value;  } }

        public Table(Estados estado, Simbolos simbolo, Direcao direcao)
        {
            this.estado = estado;
            this.simbolo = simbolo;
            this.direcao = direcao;
        }
    }
}
