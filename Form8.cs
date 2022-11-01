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
        public Form8()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
            //Modalidade cad = new Modalidade(comboBox1.Text);
            //MysqlDataReader r = cad.consultarModalidade();
            //if (r.Read())
            //{
                //txtPreco.Text = r["precoModalidade"].ToString();
               // txtQtdeAlunos.Text = r["QtdeAlunosModalidade"].ToString();
                //txtQtdeAulas.Text = r["QtdeAulasModalidade"].ToString();
            //}

        //}
    }
}
