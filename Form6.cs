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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            carregaCombo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modalidade modalidade= new Modalidade(comboBox1.Text);

            if (modalidade.excluirModaliade())
            {
               MessageBox.Show("Modalidade Excluída");
            
            }
            else
            {
               MessageBox.Show("Modalidade n Encontrada");
            }
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
