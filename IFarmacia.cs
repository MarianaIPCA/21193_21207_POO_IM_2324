using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21193_21207
{
    public interface IFarmacia
    {
        void InserirMedicamento(Medicamento medicamento);
        void MostrarMedicamentos();
        Medicamento ObterMedicamentoPorNome(string nome);
        void RemoverMedicamento(Medicamento medicamento);
       



    }
}
