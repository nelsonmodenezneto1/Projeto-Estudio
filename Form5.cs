using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudio1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            float preco = float.Parse(textbox50.Text);
            int qtdealunos = int.Parse(textbox51.Text);
            int qtdeaulas = int.Parse(textbox52.Text);
            Modalidade modalidade = new Modalidade(textBox1.Text, preco, qtdealunos, qtdeaulas);
            if (modalidade.cadastrarModalidade())
            {
                Console.WriteLine("OII");
            }
            else
            {
                Console.WriteLine("ERRO");
            }

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
