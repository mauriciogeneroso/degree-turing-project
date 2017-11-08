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

        delegate void OutputPosicaoDelegate(string data);

        public void UpdatePosPub(string data)
        {
            if (tbatual.InvokeRequired)
                tbatual.Invoke(new OutputPosicaoDelegate(UpdatePos),
                new object[] { data });
            else
                UpdatePos(data); //call directly
        }

        private void UpdatePos(string data)
        {
            tbposição.Text = data;
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
