using System;
using System.Collections.Generic;
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
        }

        public void MostrarMedicamentos()
        {
           foreach(Medicamento med in medicamentos)
           {
                Console.WriteLine(med);
           }
        }
      
        #endregion

        #endregion

    }
    
}
