using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21193_21207
{
    public class Farmaceutico : Pessoa
    {
        #region Atributos
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
        public Farmacia _Farmacia
        {
            get { return farmacia; }
            set { farmacia = value; }
        }
    
        #endregion

        #region Outros métodos
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
