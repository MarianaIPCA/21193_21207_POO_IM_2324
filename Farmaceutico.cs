/*
*	<copyright file="Farmaceutico.cs" company="MarianaIPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Mariana e Gonçalo</author>
*   <date>31/12/2023</date>
*	<description> Descreve um farmaceutico e as funções que ele pode executar apartir da classe farmácia  </description>
**/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace _21193_21207
{
    /// <summary>
    /// Classe do Farmaceutico que herda a classe pessoa
    /// </summary>
    public class Farmaceutico : Pessoa
    {
        #region Atributos
        /// <summary>
        /// Um atributo que representa a associação do farmacêutico com uma instância da classe Farmacia.
        /// </summary>
        Farmacia farmacia;

        #endregion

        #region Metodos

        #region Construtores
        public Farmaceutico(string nome, int idade, Farmacia farmacia)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.farmacia = farmacia;
        }

        #endregion

        #region Propriedades 

        /// <summary>
        /// Como já existe uma classe chamada Farmacia, dá-mos o nome de '_Farmacia', facilita o acesso à variável pretendida
        /// Utilizada na função de remover medicamento apartir da classe Farmaceutico
        /// Uma propriedade que permite acessar e modificar a instância da classe Farmacia associada ao farmacêutico.
        /// </summary>
        public Farmacia _Farmacia
        {
            get { return farmacia; }
            set { farmacia = value; }
        }
    
        #endregion

        #region Outros métodos

        /// <summary>
        /// Funções que são chamadas apartir da Farmácia para o Farmaceutico as puder utilizar
        /// </summary>
        /// <param name="medicamento"></param>
 
        public void InserirMedicamento(Medicamento medicamento)
        {
            this.farmacia.InserirMedicamento(medicamento);
        }
        public void RemoverMedicamento(Medicamento medicamento)
        {
            this.farmacia.RemoverMedicamento(medicamento);
        }
        public void MostrarMedicamentos()
        {
            this.farmacia.MostrarMedicamentos();
        }

        #endregion

        #endregion



    }
}
