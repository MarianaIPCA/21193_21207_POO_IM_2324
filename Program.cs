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
            /* Medicamento m1 = new Medicamento("Paracetamol",TipoMedicamentos.Analgesico,600,new DateTime(2024,05,01));
             Console.WriteLine("Medicamento 1:\n Nome: {0} - Tipo: {1} - Id: {2} - Data de Validade: {3} \n",m1.NomeMedicamento,m1.Tipo,m1.Id,m1.DataValidade.ToString("dd/MM/yyyy"));

             Medicamento m2 = new Medicamento("Ipobrufeno", TipoMedicamentos.Analgesico,1000,new DateTime(2024,07,07));
             Console.WriteLine("Medicamento 2:\n Nome: {0} - Tipo: {1} - Id: {2} - Data de Validade: {3} \n", m2.NomeMedicamento, m2.Tipo, m2.Id, m2.DataValidade.ToString("dd/MM/yyyy"));

             Medicamento m3 = new Medicamento("Singulair", TipoMedicamentos.AntiHistaminico,200,new DateTime(2023,12,24));
             Console.WriteLine("Medicamento 3:\n Nome: {0} - Tipo: {1} - Id: {2} - Data de Validade: {3} \n", m3.NomeMedicamento, m3.Tipo, m3.Id, m3.DataValidade.ToString("dd/MM/yyyy"));*/


            Farmacia farmacia = new Farmacia("Farmacia1", 500);

            while (true)
            {
        
                Console.WriteLine("\nOpções:");
                Console.WriteLine("1. Inserir Medicamento");
                Console.WriteLine("2. Remover Medicamento");
                Console.WriteLine("3. Mostrar Medicamentos");
                Console.WriteLine("0. Sair");

                Console.Write("Escolha uma opção: \n");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        InserirMedicamento(farmacia);
                        break;
                    case "2":
                        //RemoverMedicamento(Farmacia1);
                        break;
                    case "3":
                        MostrarMedicamentos(farmacia);
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
                Console.ReadKey();
            }
        }
 
        static void InserirMedicamento(Farmacia farmacia)
        {
            Console.Clear();
            Console.Write("Qual o nome do medicamento? ");
            String nomeMed= Console.ReadLine();

            Console.Write("Qual o tipo de medicamento? ");
            string sTipoMed= Console.ReadLine();

            TipoMedicamentos tp;
            switch (sTipoMed)
            {
                case "0":
                    tp = TipoMedicamentos.Analgesico;
                    break;

                case "1":
                    tp = TipoMedicamentos.Antibiotico;
                    break;

                case "2":
                    tp = TipoMedicamentos.AntiInflamatorio;
                    break;

                case "3":
                    tp = TipoMedicamentos.AntiHistaminico;
                    break;

                default:
                    Console.WriteLine("Opção de tipo de medicamento inválida.");
                    tp = TipoMedicamentos.Analgesico;
                    break;
            }
            Console.Write("Insira data de validade (p.ex, 01/01/2001): ");
            string userInput = Console.ReadLine(); 
            if (!DateTime.TryParse(userInput, out DateTime dataValidade))
            {
                Console.WriteLine("Formato inválido.");
            }
            farmacia.InserirMedicamento(new Medicamento(nomeMed,tp,dataValidade));
            

        }

        static void MostrarMedicamentos(Farmacia farmacia) 
        {
            farmacia.MostrarMedicamentos();
        }
     
    }
}
