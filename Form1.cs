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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (DAO_Conexao.getConexao("143.106.241.3", "cl201172", "cl201172", "cl*10102005"))
            {
                Console.WriteLine("Conectado");
            }
            else
            {
                Console.WriteLine("Erro de Conexão");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tipo = DAO_Conexao.login(textBox1.Text, textBox2.Text);
            if (tipo == 0)
                MessageBox.Show("Usuário/Senha Inválidos");
            if(tipo == 1)
            {
                MessageBox.Show("Usuário ADM");
                grpValidacao.Visible = false;
                menuStrip1.Enabled = true;
            }
            if(tipo == 2)
            {
                MessageBox.Show("Usuário Restrito");
                grpValidacao.Visible = false;
                menuStrip1.Enabled = true;
                cadastrarAlunoToolStripMenuItem.Enabled = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void L_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 cad_Aluno = new Form2();
            cad_Aluno.MdiParent = this;
            cad_Aluno.Show();
        }

        private void cadastrarLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 cad_login = new Form3();
            cad_login.MdiParent = this;
            cad_login.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 cad_excluir = new Form4();
            cad_excluir.MdiParent = this;
            cad_excluir.Show();
        }

        private void cadastrarModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 cad_modalidade = new Form5();
            cad_modalidade.MdiParent = this;
            cad_modalidade.Show();
        }

        private void excluirModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 ex_modalidade = new Form6();
            ex_modalidade.MdiParent = this;
            ex_modalidade.Show();
        }

        private void consultarModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 con_modalidade = new Form7();
            con_modalidade.MdiParent = this;
            con_modalidade.Show();
        }

        private void cadastrarTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 turmacad = new Form8();
            turmacad.MdiParent = this;
            turmacad.Show();
        }

        private void excluirTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 turmaex = new Form9();
            turmaex.MdiParent = this;
            turmaex.Show();
        }

        private void atualizarModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = 0;
            Form7 con_modalidade = new Form7(a);
            con_modalidade.MdiParent = this;
            con_modalidade.Show();
        }
    }
}
