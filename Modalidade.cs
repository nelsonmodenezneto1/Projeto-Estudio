using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio1
{
    internal class Modalidade
    {
        #region
        private string Descricao;
        private float Preco;
        private int qtde_alunos, qtde_aulas;
        private int bolinha;

        public string Descricao1 { get => Descricao; set => Descricao = value; }
        public float Preco1 { get => Preco; set => Preco = value; }
        public int Qtde_alunos { get => qtde_alunos; set => qtde_alunos = value; }
        public int Qtde_aulas { get => qtde_aulas; set => qtde_aulas = value; }

        public Modalidade (string Descricao, float Preco, int qtde_alunos, int qtde_aulas)
        {
            this.Descricao = Descricao;
            this.Preco = Preco;
            this.qtde_alunos = qtde_alunos;
            this.qtde_aulas = qtde_aulas;
        }
        public Modalidade (string Descricao)
        {
            this.Descricao = Descricao;
        }
        public Modalidade()
        {
        }

        public bool cadastrarModalidade()
        {
            bool ativo;
            ativo = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Modalidade (descricaoModalidade, precoModalidade, qtdeAlunos, qtdAulas) values('" + Descricao + "'," + Preco + "," + qtde_alunos + "," + qtde_aulas + ")", DAO_Conexao.con);
                insere.ExecuteNonQuery();
                ativo = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("lalalalala");
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return ativo;
        }
        public MySqlDataReader consultarModalidade(String descricao)
        {
            MySqlDataReader resultado = null;
            try { 
            DAO_Conexao.con.Open();
            MySqlCommand consultar = new MySqlCommand("select descricaoModalidade from Estudio_Modalidade where descricaoModalidade = '" + Descricao + "'", DAO_Conexao.con);
            resultado = consultar.ExecuteReader();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return resultado;
        }
        public MySqlDataReader cunsultarTodasModalidades()
        {

            MySqlDataReader resultado = null;
            DAO_Conexao.con.Open();
            MySqlCommand consultar = new MySqlCommand("select * from Estudio_Modalidade", DAO_Conexao.con);
            resultado = consultar.ExecuteReader();

            return resultado;

        }
        public bool atualizarModaliade()
        {
            bool ativo;
            ativo = false;

            return ativo;
        }
        public bool excluirModaliade()
        {
            bool ativo;
            ativo = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand delete = new MySqlCommand("delete from Estudio_Modalidade where descricaoModalidade ='" + Descricao + "'", DAO_Conexao.con);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }


            return ativo;
        }
        private void comboBox1()
        {

        }
    }
}
#endregion