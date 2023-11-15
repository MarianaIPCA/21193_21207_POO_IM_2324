using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21193_21207
{
    class Program
    {
        static void Main(string[] args)
        {
            Medicamento m1 = new Medicamento("Paracetamol",TipoMedicamentos.Analgesico,600,new DateTime(2024,05,01));
            Console.WriteLine("Medicamento 1:\n Nome: {0} - Tipo: {1} - Id: {2} - Data de Validade: {3} \n",m1.NomeMedicamento,m1.Tipo,m1.Id,m1.DataValidade.ToString("dd/MM/yyyy"));

            Medicamento m2 = new Medicamento("Ipobrufeno", TipoMedicamentos.Analgesico,1000,new DateTime(2024,07,07));
            Console.WriteLine("Medicamento 2:\n Nome: {0} - Tipo: {1} - Id: {2} - Data de Validade: {3} \n", m2.NomeMedicamento, m2.Tipo, m2.Id, m2.DataValidade.ToString("dd/MM/yyyy"));

            Medicamento m3 = new Medicamento("Singulair", TipoMedicamentos.AntiHistaminico,200,new DateTime(2023,12,24));
            Console.WriteLine("Medicamento 3:\n Nome: {0} - Tipo: {1} - Id: {2} - Data de Validade: {3} \n", m3.NomeMedicamento, m3.Tipo, m3.Id, m3.DataValidade.ToString("dd/MM/yyyy"));

        }
    }
}
