using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MaquinaDeTuring
{
    public partial class FormPrincipal : Form
    {
        private Thread thread;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (thread != null)
            {
                thread.Abort();
            }
            this.Close();
        }


        private void btStart_Click(object sender, EventArgs e)
        {
            int baseTriangulo = 0;
            int altura = 0;
            try
            {
                baseTriangulo = Convert.ToInt32(tbBase.Text);
                altura = Convert.ToInt32(tbAltura.Text);
            }
            catch (Exception excpt)
            {
                MessageBox.Show("Os valores informados estão incorretos", "Erro na entrada");
                Console.WriteLine(excpt.Message);
                return;
            }

            Cabecote cabecote = new Cabecote(baseTriangulo, altura);
            thread = new Thread(() =>
                cabecote.executar(this)
            );
            thread.Start();
        }

        //tbAtual
        delegate void OutputAtualDelegate(string data);

        public void UpdateAtualPub(string data)
        {
            if (tbatual.InvokeRequired)
                tbatual.Invoke(new OutputAtualDelegate(UpdateAtual),
                new object[] { data });
            else
                UpdateAtual(data); //call directly
        }

        private void UpdateAtual(string data)
        {
            tbatual.Text = data;
        }

        //tbPosicao
        delegate void OutputPosicaoDelegate(string data);

        public void UpdatePosPub(string data)
        {
            if (tbposição.InvokeRequired)
                tbposição.Invoke(new OutputPosicaoDelegate(UpdatePos),
                new object[] { data });
            else
                UpdatePos(data); //call directly
        }

        private void UpdatePos(string data)
        {
            tbposição.Text = data;
        }

        //tbPosicaoStats
        delegate void UpdatePosicaoStatusDelegate(string data);

        public void UpdatePosicaoStatsPub(string data)
        {
            if (tbPosicaoStats.InvokeRequired)
                tbPosicaoStats.Invoke(new UpdatePosicaoStatusDelegate(UpdatePosicaoStats),
                new object[] { data });
            else
                UpdatePosicaoStats(data); //call directly
        }

        private void UpdatePosicaoStats(string data)
        {
            tbPosicaoStats.Text = data;
        }

        //tbEstadoAtualStats
        delegate void UpdateStatusAtualDelegate(string data);

        public void UpdateStatusAtualPub(string data)
        {
            if (tbEstadoAtualStats.InvokeRequired)
                tbEstadoAtualStats.Invoke(new UpdateStatusAtualDelegate(UpdateStatusAtual),
                new object[] { data });
            else
                UpdateStatusAtual(data); //call directly
        }

        private void UpdateStatusAtual(string data)
        {
            tbEstadoAtualStats.Text = data;
        }

        //tbValorLidoStats
        delegate void UpdateValorLidoDelegate(string data);

        public void UpdateValorLidoPub(string data)
        {
            if (tbValorLidoStats.InvokeRequired)
                tbValorLidoStats.Invoke(new UpdateValorLidoDelegate(UpdateValorLido),
                new object[] { data });
            else
                UpdateValorLido(data); //call directly
        }

        private void UpdateValorLido(string data)
        {
            tbValorLidoStats.Text = data;
        }







        private void fechar(object sender, FormClosedEventArgs e)
        {
            if (thread != null)
            {
                thread.Abort();
            }
        }
    }
}
