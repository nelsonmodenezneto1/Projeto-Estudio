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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            carregaCombo();
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            button1.Visible = false;

        }

        public Form7(int a)
        {
            InitializeComponent();
            carregaCombo();

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
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand seleModalidade = new MySqlCommand("Select * from Estudio_Modalidade where descricaoModalidade like'" + comboBox1.Text + "'", DAO_Conexao.con);
                MySqlDataReader r = seleModalidade.ExecuteReader();
                r.Read();
                textBox2.Text = r.GetString("precoModalidade").ToString();
                textBox3.Text = r.GetString("qtdeAlunos").ToString();
                textBox4.Text = r.GetString("qtdeAulas").ToString();
                r.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally { DAO_Conexao.con.Close(); }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float preco = float.Parse(textBox2.Text);
            int qtdeAluno = int.Parse(textBox3.Text);
            int qtdeAula =  int.Parse(textBox4.Text);
            Modalidade modalidade = new Modalidade(comboBox1.Text, preco, qtdeAluno, qtdeAula);
            if(modalidade.atualizarModalidade())
            {
                MessageBox.Show("Atualizado");
            }
            else
            {
               MessageBox.Show("Erro na Atualização");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
