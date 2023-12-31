/*
*	<copyright file="Pessoa.cs" company="MarianaIPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Mariana e Gonçalo</author>
*   <date>31/12/2023</date>
*	<description> Descreve um medicamento </description>
**/

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

        public Pessoa()
        {
            this.nome = "Não atribuído";
            this.idade = -1;
        }

        #endregion

        #region Propriedades

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Idade
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
