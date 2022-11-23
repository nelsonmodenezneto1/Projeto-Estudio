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
    public partial class Form9 : Form
    {
        public static int id;
        public Form9()
        {
            InitializeComponent();
            carregaCombo1();
            id = 0;
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        public void carregaCombo1()
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
            int busca = modalidade.buscarId();
            if (busca == 0)
            {
                MessageBox.Show("ID não encontrado!");
            }
            else
            {
                id = busca;
                Turma turma = new Turma(id);
                MySqlDataReader r = turma.consultarTurma();
                while (r.Read())
                {
                    comboBox2.Items.Add(r["dia_semana"].ToString());
                }
                DAO_Conexao.con.Close();

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Modalidade modalidade = new Modalidade(comboBox1.Text);
            int busca = modalidade.buscarId();
            if (busca == 0)
            {
                MessageBox.Show("ID não encontrado!");
            }
            else
            {
                id = busca;
                Turma turma = new Turma(id, comboBox2.Text);
                MySqlDataReader resultado = turma.consultarTurma01();
                while (resultado.Read())
                {
                    comboBox3.Items.Add(resultado["hora"].ToString());
                }
                DAO_Conexao.con.Close();
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modalidade modalidade = new Modalidade(comboBox1.Text);
            int busca = modalidade.buscarId();
            if (busca == 0)
            {
                MessageBox.Show("ID não encontrado!");
            }
            else
            {
                id = busca;
                Turma t = new Turma(id, comboBox2.Text, comboBox3.Text);
                if(t.excluirTurma())
                {
                    Console.WriteLine("Excluído");
                    comboBox1.Text="";
                    comboBox2.Text = "";
                    comboBox3.Text = "";
                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
                    carregaCombo1();
                }
                else
                {
                    Console.WriteLine("Erro");
                }
            }
        }
    }
}
