using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeTuring
{
    class RegistradorDeEstado
    {
        private Estados estadoAtual;
        public Estados EstadoAtual { get { return estadoAtual; } set { estadoAtual = value; } }
    }
}
