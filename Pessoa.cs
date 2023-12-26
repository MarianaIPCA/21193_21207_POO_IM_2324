using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21193_21207
{
    public class Pessoa
    {
        #region Atributos

        private string nome;
        private int idade;

        #endregion

        #region Metodos

        #region Construtores

        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        #endregion

        #region Propriedades

        //Nome da farmácia
        public string NomePessoa
        {
            get { return nome; }
            set { nome = value; }
        }

        public int IdadePessoa
        {
            get { return idade; }
            set { idade = value; }
        }
        #endregion

        #region Overrides
        #endregion

        #endregion
    }
}
