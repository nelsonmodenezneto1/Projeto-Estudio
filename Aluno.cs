using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Estudio1
{
    class Aluno
    {
        private String CPF;
        private String Nome;
        private String Rua;
        private String Numero;
        private String Complemento;
        private String Bairro;
        private String CEP;
        private String Cidade;
        private String Estado;
        private String Telefone;
        private String Email;
        private byte[] Foto;
        private bool Ativo;

        public string CPF1 { get => CPF; set => CPF = value; }
        public string Nome1 { get => Nome; set => Nome = value; }
        public string Rua1 { get => Rua; set => Rua = value; }
        public string Numero1 { get => Numero; set => Numero = value; }
        public string Complemento1 { get => Complemento; set => Complemento = value; }
        public string Bairro1 { get => Bairro; set => Bairro = value; }
        public string CEP1 { get => CEP; set => CEP = value; }
        public string Cidade1 { get => Cidade; set => Cidade = value; }
        public string Estado1 { get => Estado; set => Estado = value; }
        public string Telefone1 { get => Telefone; set => Telefone = value; }
        public string Email1 { get => Email; set => Email = value; }
        public bool Ativo1 { get => Ativo; set => Ativo = value; }

        public Aluno(string cPF, string nome, string rua, string numero, string complemento, string bairro, string cEP, string cidade, string estado, string telefone, string email, bool ativo)
        {
            DAO_Conexao.getConexao("143.106.241.3", "cl20172", "cl201172", "cl*10102005");
            CPF = cPF;
            Nome = nome;
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            CEP = cEP;
            Cidade = cidade;
            Estado = estado;
            Telefone = telefone;
            Email = email;
            Ativo = ativo;
        }

        public string getCPF()
        {
            return this.CPF;
        }
        public void setCPF(string CPF)
        {
            this.CPF = CPF;
        }
        public string getNome()
        {
            return this.Nome;
        }
        public void setNome(string nome)
        {
            this.Nome = nome;
        }
        public string getRua()
        {
            return this.Rua;
        }
        public void setRua(string rua)
        {
            this.Rua = rua;
        }
        public string getNumero()
        {
            return this.Numero;
        }
        public void setNumero(string numero)
        {
            this.Numero = numero;
        }
        public string getComplemento()
        {
            return this.Complemento;
        }
        public void setComplemento(string complemento)
        {
            this.Complemento = complemento;
        }
        public string getBairro()
        {
            return this.Complemento;
        }
        public void setBairro(string bairro)
        {
            this.Bairro = bairro;
        }
        public string getCEP()
        {
            return this.CEP;
        }
        public void setCEP(string cep)
        {
            this.CEP = cep;
        }
        public string getCidade()
        {
            return this.Cidade;
        }
        public void setCidade(string cidade)
        {
            this.Cidade = cidade;
        }
        public string getEstado()
        {
            return this.Estado;
        }
        public void setEstado(string estado)
        {
            this.Estado = estado;
        }
        public string getTelefone()
        {
            return this.Telefone;
        }
        public void setTelefone(string telefone)
        {
            this.Telefone = telefone;
        }
        public string getEmail()
        {
            return this.Email;
        }
        public void setEmail(string email)
        {
            this.Email = email;
        }
        public bool getAtivo()
        {
            return this.Ativo;
        }
        public void setAtivo(bool ativo)
        {
            this.Ativo = ativo;
        }
        public Aluno()
        {
        }
        public bool cadastrarAluno()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Aluno (CPFAluno, nomeAluno, ruaAluno, numeroAluno, bairroAluno, complementoAluno, CEPAluno, cidadeAluno, estadoAluno, telefoneAluno, emailAluno) values('" +CPF+ "','" +Nome+ "','" +Rua+ "','" +Numero+ "','" +Bairro+ "','" +Complemento+ "','" +CEP+ "','" +Cidade+ "','" +Estado+ "','" +Telefone+ "','" +Email+ "')",DAO_Conexao.con);
                insere.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return cad;
        }

       
    }
}
