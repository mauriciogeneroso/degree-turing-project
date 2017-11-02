using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaquinaDeTuring
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
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
            } catch(Exception excpt)
            {
                MessageBox.Show("Os valores informados estão incorretos", "Erro na entrada");
                Console.WriteLine(excpt.Message);
                return;
            }

            Cabecote cabecote = new Cabecote(baseTriangulo, altura);


        }
    }
}
