using _21193_21207.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _21193_21207
{
    /// <summary>
    /// Esta camada intermédia tem como objetivo organizar as funções
    /// </summary>
    public class CamadaIntermedia
    {
        /// <summary>
        /// Função que remove medicamento, utilizando um método de verificação para confirmar 
        /// se o medicamento existe.
        /// </summary>
        /// <param name="farmaceutico"></param>
        /// <returns></returns>
        
        public static bool RemoverMedicamento(Farmaceutico farmaceutico)
        {
            Console.Clear();
            Console.Write("Qual o nome do medicamento que deseja remover? \n");
            String nomeMed = Console.ReadLine();

            // Verificar se o medicamento existe na farmácia
            Medicamento medicamento = farmaceutico._Farmacia.ObterMedicamentoPorNome(nomeMed);

            if (medicamento == null)
            {
                Console.WriteLine("Medicamento não encontrado na farmácia.");
                return false;
            }
            else
            {
                farmaceutico.RemoverMedicamento(medicamento);
                Console.WriteLine("Medicamento removido.");
                return true;
            }
        }
        /// <summary>
        /// Função chamada pelo farmaceutico que mostra a lista dos medicamentos inseridos.
        /// </summary>
        /// <param name="farmaceutico"></param>
     
        public static void MostrarMedicamentos(Farmaceutico farmaceutico)
        {
            farmaceutico.MostrarMedicamentos();
        }

        
        /// <summary>
        /// Função que permite inserir medicamento 
        /// </summary>
        /// <param name="farmaceutico"></param>
        /// <returns></returns>
  
        public static bool InserirMedicamento(Farmaceutico farmaceutico)
        {
            Console.Clear();
            Console.Write("Qual o nome do medicamento? \n");
            String nomeMed = Console.ReadLine();

            Console.Write("Qual o tipo de medicamento? ");
            Console.Write("\n0- Analgesico | 1- Antibiotico | 2- AntiInflamatorio | 3-AntiHistaminico \n");
            string sTipoMed = Console.ReadLine();

            TipoMedicamentos tp;

            try
            {
                if (int.Parse(sTipoMed) == 0)
                {
                    tp = TipoMedicamentos.Analgesico;
                }
                else if (int.Parse(sTipoMed) == 1)
                {
                    tp = TipoMedicamentos.Antibiotico;
                }
                else if (int.Parse(sTipoMed) == 2)
                {
                    tp = TipoMedicamentos.AntiInflamatorio;
                }
                else if (int.Parse(sTipoMed) == 3)
                {
                    tp = TipoMedicamentos.AntiHistaminico;
                }
                else
                {
                    throw new TipoInvalido("Tipo é inválido.");
                }
            }
            catch (TipoInvalido tipoInvalido)
            {
                Console.WriteLine(tipoInvalido.Message);
                return false;
            }

            Console.Write("Insira data de validade (p.ex, 01/01/2001): \n");
            string userInput = Console.ReadLine();
            //Console.Write("Pressione Enter para continuar");
            if (!DateTime.TryParse(userInput, out DateTime dataValidade))
            {
                Console.WriteLine("Formato inválido.");
                return false;
            }
            farmaceutico.InserirMedicamento(new Medicamento(nomeMed, tp, dataValidade));
            Console.Write("Medicamento inserido.\n");
            return true;

        }

    }
}
