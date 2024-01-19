/*
*	<copyright file="Farmacia.cs" company="MarianaIPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Mariana e Gonçalo</author>
*   <date>31/12/2023</date>
*	<description> Descreve um medicamento </description>
**/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;



namespace _21193_21207
{
    

    [Serializable]
    public class Farmacia : IFarmacia
    {

        #region Atributos
        /// <summary>
        /// Atributos
        /// </summary>
        static Farmacia[] Farmacias = new Farmacia[0]; //array - não está a ser utilizado

        private static Farmacia instanciaUnica;
        const int MAX = 500;
        private string nome;
        private List<Medicamento> medicamentos= new List<Medicamento> { }; //lista de medicamentos criada
        private int totMedicamentos; //indica o total de medicamentos existentes
        private string filePath = "dadosfarmacia.bin"; // nome do ficheiro .bin que vai ficar guardado os medicamentos inseridos

        #endregion

        #region Metodos

        #region Construtores
        /// <summary>
        /// Construtores da farmácia
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="tot"></param>
        public Farmacia(string nome, int tot)
        {
            this.nome = nome;
            totMedicamentos = tot; 

        }
        public Farmacia()
        {
            this.nome = "Não atribuído";
            this.totMedicamentos = 0;
        }

        /// <summary>
        /// Instância da farmácia criada 
        /// </summary>
        /// <returns></returns>
        public static Farmacia ObterInstanciaUnica()
        {
            if (instanciaUnica == null)
            {
                instanciaUnica = new Farmacia("Farmacia1", 0);
            }

            return instanciaUnica;
        }

        #endregion

        #region Propriedades
        /// <summary>
        /// As propriedades conseguem mostrar a informação privada dos atributos de uma classe
        /// </summary>
        public string NomeFarmacia
        {
            get { return nome; }
            set { nome = value; }
        }

        #endregion

        #region Overrides
        #endregion

        #region Outros Metodos
        /// <summary>
        /// Função que insere os medicamentos novos e os guarda no ficheiro de texto criado.
        /// </summary>
        /// <param name="medicamento"></param>
       
        public void InserirMedicamento(Medicamento medicamento)
        {
            this.medicamentos.Add(medicamento);
            this.totMedicamentos++;
            GuardarDados(filePath,this); /****/
        }
        /// <summary>
        /// Função que mostra a lista dos medicamentos já inseridos na lista medicamentos
        /// </summary>
        public void MostrarMedicamentos()
        {
            if (medicamentos.Count == 0)
            {
                Console.WriteLine("Nenhum medicamento encontrado.");
            }
            else
            {
                foreach (Medicamento med in medicamentos)
                {
                    Console.WriteLine(med);
                }
            }
        }

        /// <summary>
        /// Verifica se existe o medicamento na lista dos medicamentos
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>

        public Medicamento ObterMedicamentoPorNome(string nome)
        { 
            //Seja o nome do medicamento com letras Maiusculas ou Minusculas, ele vai encontrar o mesmo.
            return medicamentos.FirstOrDefault(m => string.Equals(m.NomeMedicamento, nome, StringComparison.OrdinalIgnoreCase));  
        }

        /// <summary>
        /// Função que remove os medicamentos existentes na lista medicamentos
        /// </summary>
        /// <param name="medicamento"></param>
        public void RemoverMedicamento(Medicamento medicamento)
        {
            medicamentos.Remove(medicamento);
            GuardarDados(filePath,this); /****/
        }
        /// <summary>
        /// Guarda os dados em um ficheiro binário
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="farmacia"></param>
        static void GuardarDados(string filePath,Farmacia farmacia)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    formatter.Serialize(fs, farmacia);
                }

                Console.WriteLine("Dados guardados com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
        }
        /// <summary>
        /// Lê os dados de um ficheiro binário
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        static Farmacia LerDados(string filePath)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    Farmacia deserializedObject = (Farmacia)formatter.Deserialize(fs);
                    return deserializedObject;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
                return null;
            }
        }
        
        #endregion
  
        #endregion

    }
}
    

