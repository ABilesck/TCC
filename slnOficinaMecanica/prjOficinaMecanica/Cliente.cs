using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjOficinaMecanica.model
{
    class Cliente
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string documentoSocial;

        public string DocumentoSocial
        {
            get { return documentoSocial; }
            set { documentoSocial = value; }
        }

        private string registroGeral;

        public string RegistroGeral
        {
            get { return registroGeral; }
            set { registroGeral = value; }
        }


        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string logradouro;

        public string Logradouro
        {
            get { return logradouro; }
            set { logradouro = value; }
        }

        private string bairro;

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        private string cidade;

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        private string complemento;

        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        private string uf;

        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }

        private string cep;

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public Cliente()
        {
        }

        public void Inserir(Cliente cliente)
        {
           
        }
    }
}
