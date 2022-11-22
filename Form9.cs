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
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Modalidade m = new Modalidade();
            MySqlDataReader modalidade = m.consultarTodasModalidades();
            while (modalidade.Read())
            {
                comboBox1.Items.Add(modalidade["descricaoModalidade"].ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Modalidade modalidade = new Modalidade(comboBox1.Text);
            Turma turma = new Turma(modalidade.buscarId());
            MySqlDataReader resultado = turma.consultarTurma();
            while (resultado.Read())
            {
                comboBox2.Items.Add(resultado["diasemanaTurma"]);
            }
            DAO_Conexao.con.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Modalidade modalidade = new Modalidade(comboBox1.Text);
            Turma turma = new Turma(modalidade.buscarId(),comboBox2.Text);
            MySqlDataReader resultado = turma.consultarTurma01();
            while (resultado.Read())
            {
                comboBox2.Items.Add(resultado["horaTurma"]);
            }
            DAO_Conexao.con.Close();
        }
    }
}
