using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _21193_21207
{
    public class Farmacia
    {
        #region Atributos

        const int MAX = 500;
        private string nome;
        private List<Medicamento> medicamentos= new List<Medicamento> { };
        private int totMedicamentos; //indica o total de medicamentos existentes
        private string filePath = "dadosfarmacia.txt";

        #endregion

        #region Metodos

        #region Construtores

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

        #endregion

        #region Propriedades

        public string NomeFarmacia
        {
            get { return nome; }
            set { nome = value; }
        }
        #endregion

        #region Overrides
        #endregion

        #region Outros Metodos

        public void InserirMedicamento(Medicamento medicamento)
        {
            this.medicamentos.Add(medicamento);
            this.totMedicamentos++;
            this.FicheiroMedicamentos();
        }

        public void MostrarMedicamentos()
        {
           foreach(Medicamento med in medicamentos)
           {
                Console.WriteLine(med);
           }
        }
        //**************************************************************
        //Verifica se existe o medicamento na lista dos medicamentos
        public Medicamento ObterMedicamentoPorNome(string nome)
        { 
            //Seja o nome do medicamento com Letras Maiusculas ou Minusculas, ele vai encontrar o mesmo.
            return medicamentos.FirstOrDefault(m => string.Equals(m.NomeMedicamento, nome, StringComparison.OrdinalIgnoreCase));  
        }

        public void RemoverMedicamento(Medicamento medicamento)
        {
            medicamentos.Remove(medicamento);
        }

        //Função que exporta todos os medicamentos para um ficheiro de texto
        void FicheiroMedicamentos()
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine($"Nome: {this.NomeFarmacia}");

                writer.WriteLine($"Total de Medicamentos: {totMedicamentos}");

                writer.WriteLine("Medicamentos:");
                writer.WriteLine("Nome      | Tipo      | Data de Validade");
                foreach (Medicamento medicamento in this.medicamentos)
                {
                    writer.WriteLine($"-{medicamento.NomeMedicamento} - {medicamento.TipoMed} - {medicamento.DataValidade.ToString("dd/MM/yyyy")}");
                }
            }
        }



    }

        #endregion

        #endregion

 }
    

