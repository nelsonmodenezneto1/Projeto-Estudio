using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudio1
{
    internal class Modalidade
    {
        #region
        private string Descricao;
        private float Preco;
        private int qtde_alunos, qtde_aulas;

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
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Modalidade (descricaoModalidade, precoModalidade, qtdeAlunos, qtdeAulas) values('"+ Descricao +"',"+ Preco +","+ qtde_alunos + "," + qtde_aulas + ")", DAO_Conexao.con);
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
        public MySqlDataReader consultarModalidade()
        {
            MySqlDataReader resultado = null;
            try { 
            DAO_Conexao.con.Open();
            MySqlCommand consultar = new MySqlCommand("select * from Estudio_Modalidade where descricaoModalidade = '" + Descricao + "'", DAO_Conexao.con);
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

        public MySqlDataReader consultarTodasModalidades()
        {
            MySqlDataReader resultado = null;
            try { 
            DAO_Conexao.con.Open();
            MySqlCommand consultar = new MySqlCommand("select * from Estudio_Modalidade where ativa =0", DAO_Conexao.con);
            resultado = consultar.ExecuteReader();
            }
            catch(Exception ex)
            {
                Console.WriteLine("lalalal");
                DAO_Conexao.con.Close();
            }

            return resultado;
        }
        public int buscarId()
        {
            MySqlDataReader buscar = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand busca = new MySqlCommand("SELECT idEstudio_Modalidade FROM Estudio_Modalidade WHERE descricaoModalidade like '" + Descricao + "'", DAO_Conexao.con);
                buscar = busca.ExecuteReader();
                if (buscar.Read())
                {
                    return Int32.Parse(buscar["idEstudio_Modalidade"].ToString());
                }
                else
                return -1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return -1;
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
        }

        public bool atualizarModalidade()
        {
            bool ativo;
            ativo = false;

            try {
                DAO_Conexao.con.Open();
                MySqlCommand atualizar = new MySqlCommand("update Estudio_Modalidade set precoModalidade =" + Preco + ", qtdeAlunos =" + qtde_alunos + ", qtdeAulas =" + qtde_aulas + " where descricaoModalidade like '"+ Descricao+"'",DAO_Conexao.con);
                Console.WriteLine("update Estudio_Modalidade set precoModalidade =" + Preco + ", qtdeAlunos =" + qtde_alunos + ", qtdeAulas =" + qtde_aulas + "where descricaoModalidade like '" + Descricao + "'");
                atualizar.ExecuteNonQuery();
                ativo = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine("lalalal");
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return ativo;
        }
        public bool excluirModaliade()
        {
            bool pou;
            pou = false;
            try
            {
                DAO_Conexao.con.Open();
                Console.WriteLine("UPDATE Estudio_Modalidade SET ativa=1 where descricaoModalidade = '" + Descricao + "'");
                MySqlCommand delete = new MySqlCommand("UPDATE Estudio_Modalidade SET ativa=1 where descricaoModalidade = '"+ Descricao +"'", DAO_Conexao.con);
                delete.ExecuteNonQuery();
                pou = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("lalalalala");
            }
            finally
            {
                DAO_Conexao.con.Close();
            }


            return pou;
        }
        private void comboBox1()
        {

        }
    }
}
#endregion