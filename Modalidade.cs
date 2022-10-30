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

            return ativo;
        }
        public MySqlDataReader consultarModalidade()
        {
            bool ativo;
            ativo = false;

            return ativo;
        }
        public MySqlDataReader cunsultarTodasModalidades()
        {
            bool ativo;
            ativo = false;

            return ativo;
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

            return ativo;
        }
    }
}
#endregion