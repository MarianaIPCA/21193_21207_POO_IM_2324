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

public enum TipoMedicamentos
{
    Analgesico,
    Antibiotico,
    AntiInflamatorio,
    AntiHistaminico

}
namespace _21193_21207
{
    public class Medicamento
    {
        #region Atributos

        private string nome;
        private TipoMedicamentos tipo;
        private int id;
        private DateTime dataValidade;

        #endregion

        #region Metodos

        #region Construtores

        public Medicamento(string nomeMed, TipoMedicamentos t,int idMed, DateTime dv)  
        {
            this.nome = nomeMed;
            this.tipo = t;
            this.id = idMed;
            this.dataValidade = dv;
        }

        #endregion

        #region Propriedades 
        //as propriedades conseguem mostrar a informação privada dos atributos de uma classe
        public string NomeMedicamento
        {
            set { nome = value; }
            get { return nome; }
        }

        public TipoMedicamentos Tipo
        { 
            set { tipo = value; }
            get { return tipo; } 
        }

        public int Id
        {
            set { id = value; }
            get { return id; }
        }

        public DateTime DataValidade
        {
            set { dataValidade = value; }
            get { return dataValidade; }
        }

        #endregion

        #region Overrides
        #endregion

        #region OutrosMetodos
        #endregion

        #endregion
    }
}
