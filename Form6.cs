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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modalidade modalidade= new Modalidade(textBox1.Text);

            if (modalidade.excluirModaliade())
            {
               MessageBox.Show("Modalidade Excluída");
            }
            else
            {
               MessageBox.Show("Modalidade n Encontrada");
            }
        }
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
