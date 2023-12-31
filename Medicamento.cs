/*
*	<copyright file="Medicamento.cs" company="MarianaIPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Mariana e Gonçalo</author>
*   <date>15/10/2023 </date>
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
        private DateTime dataValidade;

        #endregion

        #region Metodos

        #region Construtores

        public Medicamento(string nomeMed, TipoMedicamentos t, DateTime dv)  
        {
            this.nome = nomeMed;
            this.tipo = t;       
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

        public TipoMedicamentos TipoMed
        { 
            set { tipo = value; }
            get { return tipo; } 
        }
        public DateTime DataValidade
        {
            set { dataValidade = value; }
            get { return dataValidade; }
        }

        #endregion
        //Este método é utilizado para agrupar métodos que são sobrescritos de uma classe base
        #region Overrides
        //neste caso, o que faz é representar uma string formatada para apresentar o medicamento, que retorna os respectivos dados*/
        public override string ToString()
        {
            return("-> Nome: " + this.nome + " - Tipo: " + this.tipo.ToString()+ " - Data de Validade: " + this.DataValidade.ToString("dd/MM/yyyy"));
        }

        #endregion

        #region OutrosMetodos
        #endregion

        #endregion
    }
}
