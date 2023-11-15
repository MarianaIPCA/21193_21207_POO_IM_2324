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
    Antibiotico,
    AntiInflamatorio,
    AntiAlergico

}
namespace _21193_21207
{
    public class Medicamento
    {
        #region Atributos

        private string nome;
        private TipoMedi tipo;
        public int id;
        private DateTime dataValidade;

        #endregion

        #region Metodos

        #region Construtores

        public Medicamento(string nomeMed, TipoMedi t,int idMed, DateTime dv)  
        {
            this.nome = nomeMed;
            this.tipo = t;
            this.dataValidade = dv;
        }

        #endregion

        #region Propriedades 
        //as propriedades conseguem mostrar a informação privada dos atributos de uma classe
        public string Nome
        {
            set { nome = value; }
            get { return nome; }
        }

        public TipoMedi Tipo
        { 
            set { tipo = value; }
            get { return tipo; } 
        }

        //verificar se está correto
        public DateTime dataValidade
        {
            set { data = value; }
            get { return data; }
        }

        #endregion
        
        
        #endregion
    }
}
