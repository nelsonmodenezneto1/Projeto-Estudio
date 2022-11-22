using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio1
{
    internal class Turma
    {
        private String professor, dia_semana, hora;
        private int modalidade;

        public string Professor { get => professor; set => professor = value; }
        public string Dia_semana { get => dia_semana; set => dia_semana = value; }
        public string Hora { get => hora; set => hora = value; }
        public int Modalidade { get => modalidade; set => modalidade = value; }

        public Turma(int modalidade, string professor, string dia_semana, string hora)
        {
            this.modalidade = modalidade;
            this.professor = professor;
            this.dia_semana = dia_semana;
            this.hora = hora;
        }
        public Turma(int modalidade)
        {
            this.modalidade = modalidade;
        }

        public Turma(int modalidade, String dia_semana)
        {
            this.modalidade = modalidade;
        }

        public bool cadastrarTurma()
        {
            bool resultado = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand cadastrar = new MySqlCommand("insert into Estudio_Turma (idModalidade, professorTurma, diasemanaTurma, horaTurma) values(" + modalidade + ",'" + professor + "','" + dia_semana + "','" + hora + "')", DAO_Conexao.con);
                cadastrar.ExecuteNonQuery();
                resultado = true;
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
        public bool excluirTurma()
        {
            bool resultado = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand deletar = new MySqlCommand("delete from Estudio_Turma where idModalidade = (" + modalidade + ")", DAO_Conexao.con);
                deletar.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return resultado;
        }
        public MySqlDataReader consultarTurma()
        {
            MySqlDataReader consultar = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from Estudio_Turma WHERE id_modalidade=" + modalidade + " and diasemanaTurma like '" + dia_semana + "'", DAO_Conexao.con);
                consultar = consulta.ExecuteReader();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return consultar;
        }
        public MySqlDataReader consultarTurma01()
        {
            MySqlDataReader consultar = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from Estudio_Turma WHERE id_modalidade=" + modalidade + "", DAO_Conexao.con);
                consultar = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return consultar;
        }
    }
}
