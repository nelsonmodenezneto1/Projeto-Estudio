using MySql.Data.MySqlClient;
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
    public partial class Form8 : Form
    {
        public static int id;
        public Form8()
        {
            InitializeComponent();
            carregaCombo();
            Modalidade modalidade = new Modalidade();
            MySqlDataReader r = modalidade.consultarTodasModalidades();
            while (r.Read())
            {
                dataGridView1.Rows.Add(r["descricaoModalidade"].ToString());
            }
            DAO_Conexao.con.Close();
            id = 0;
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                MessageBox.Show("Modalidade inválida.");
            }
            else
            {
                Turma t = new Turma(id, textBox4.Text, textBox3.Text, maskedTextBox1.Text);
                if (t.cadastrarTurma())
                {
                    MessageBox.Show("Cadastro feito com sucesso");
                }
                else
                    MessageBox.Show("Erro de cadastro!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void carregaCombo()
        {
            Modalidade modalidade = new Modalidade();
            MySqlDataReader r = modalidade.consultarTodasModalidades();
            while (r.Read())
            {
                comboBox1.Items.Add(r["descricaoModalidade"].ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Modalidade modalidade = new Modalidade(comboBox1.Text);
            int id = modalidade.buscarId();
            if (id == -1)
            {
                MessageBox.Show("ID não encontrado!");
            }
            else
            {
                id = id;
            }
        }
    }
}
