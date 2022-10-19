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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Aluno aluno = new Aluno(txtCPF.Text);
            if (e.KeyChar == 13)
            {
                if(aluno.consultarAluno())
                {
                    MessageBox.Show("Aluno Excluído");
                }
                else
                {
                    MessageBox.Show("Aluno n Encontrado");
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
