/*
*	<copyright file="Medicamento.cs" company="MarianaIPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Mariana e Gonçalo</author>
*   <date>15/10/2023 03:17:50 PM</date>
*	<description> Descreve um medicamento </description>
**/

using System;
using System.Web;

public enum TipoMedi
{
    Analgesico,
    Antibiotico
}
namespace _21193_21207
{
    public class Medicamento
    {
        #region Atributos

        private string nome;
        private TipoMedi tipo;
        DateTime dataValidade;

        #endregion

        #region Metodos

        #region Construtores

        public Medicamento()
        {
            nome = "";
            tipo = TipoMedi.Analgesico;
            dataValidade = DateTime.Now;
        }

        public Medicamento(string nomeMed, TipoMedi t)
        {
            nome = nomeMed;
            tipo = t;
        }

        #endregion

        #region Propriedades

        public string Nome
        {
            set { nome = value; }
            get { return nome; }
        }

        public TipoMedi Tipo
        { 
            get { return tipo; } 
            set { tipo = value; }
        }

        #endregion
        
        
        #endregion
    }
}
