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
           

            //É criada uma farmácia com um total de medicamentos que podem existir
            Farmacia farmacia = new Farmacia("Farmacia1", 0);
            Farmaceutico farmaceutico = new Farmaceutico("Pedro Areias", 45, farmacia);

            //Menu inicial
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
                        InserirMedicamento(farmaceutico);
                        break;
                    case "2":
                        RemoverMedicamento(farmaceutico);
                        break;
                    case "3":
                        MostrarMedicamentos(farmaceutico);
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
        //Função que permite inserir medicamento 
        static void InserirMedicamento(Farmaceutico farmaceutico)
        {
            Console.Clear();
            Console.Write("Qual o nome do medicamento? \n");
            String nomeMed= Console.ReadLine();

            Console.Write("Qual o tipo de medicamento? ");
            Console.Write("\n0- Analgesico | 1- Antibiotico | 2- AntiInflamatorio | 3-AntiHistaminico \n");
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
            Console.Write("Insira data de validade (p.ex, 01/01/2001): \n"); //REMOVER ENTER DUPLO **********
            string userInput = Console.ReadLine();
            //Console.Write("Pressione Enter para continuar");
            if (!DateTime.TryParse(userInput, out DateTime dataValidade))
            {
                Console.WriteLine("Formato inválido.");
            }
            farmaceutico.InserirMedicamento(new Medicamento(nomeMed,tp,dataValidade));
            Console.Write("Medicamento inserido.\n");

        }

        static void MostrarMedicamentos(Farmaceutico farmaceutico) 
        {
            farmaceutico.MostrarMedicamentos();
        }

        //*****************************************************************************
        static void RemoverMedicamento(Farmaceutico farmaceutico)
        {
            Console.Clear();
            Console.Write("Qual o nome do medicamento que deseja remover? \n");
            String nomeMed = Console.ReadLine();

            // Verificar se o medicamento existe na farmácia
            Medicamento medicamento = farmaceutico._Farmacia.ObterMedicamentoPorNome(nomeMed);

            if (medicamento == null)
            {
                Console.WriteLine("Medicamento não encontrado na farmácia.");
            }
            else
            {
                farmaceutico.RemoverMedicamento(medicamento);
                Console.WriteLine("Medicamento removido.");
            }
        }


    }
}
