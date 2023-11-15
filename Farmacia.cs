using System;

namespace _21193_21207
{
   public class Farmacia 
    {
        #region Atributos

        const int MAX = 500;
        private string nome;
        private Medicamento[] medicamentos; //contém os medicamentos inseridos na classe Farmácia
        private int totMedicamentos; //indica o total de medicamentos existentes

        #endregion

        #region Metodos

        #region Construtores

        public Farmacia(string nome, int tot)
        {
            this.nome = nome;
            totMedicamentos = tot;
            
            //Alocar memória para o array
            medicamentos = new Medicamento[MAX];
            //Inicializar
            for (int i = 0; i < MAX; i++)
            {
                medicamentos[i] = new Medicamento("Paracetamol", TipoMedicamentos.Analgesico, 600, new DateTime(2024, 05, 01));
            }
        }

        #endregion

        #region Propriedades

         //Nome da farmácia
        public string NomeFarmacia
        {
            get { return nome; }
            set { nome = value; }
        }
        #endregion

        #region Overrides
        #endregion

        #region Outros Metodos

        /*public bool InsereMedicamentoFarmacia(Medicamento m1) { }
         {
             //Validações
             if (ExisteMedicamentoFarmacia(m1)) return false;
             medicamentos[totMedicamentos] = m1;
             totMedicamentos++;
             return true;

         }*/

        //Este metodo verifica se existe
        /* public bool ExisteMedicamentoFarmacia(string nome, TipoMedicamentos tipo)
        {
            foreach (Medicamento m in medicamentos)
            {
                if (m.NomeMedicamento.Equals(nome) && m.Tipo == tipo) return true;
            }
            return false;
        }*/


        //Método que permite mostrar todos os medicamentos
        public void MostraMedicamentos() { }
        /*{
           /* for (int i = 0; i < totMedicamentos; i++)
            {
                Console.WriteLine(medicamentos[i].NomeFarmacia);
            }
        }*/

        /*public int QuantosMedicamentosExistem(string nome, TipoMedicamentos tipo) { }
        {
            int tot = 0;
            foreach (Medicamento m in medicamentos)
            {
                if (m.Nome == nome && m.Tipo == tipo) tot++;
            }
            return tot;
        }*/

       

        
        #endregion

        #endregion

       
    }
}
