/*
*	<copyright file="Program.cs" company="MarianaIPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Mariana e Gonçalo</author>
*   <date>31/12/2023</date>
*	<description> Main - executa as funções e apresenta o menu  </description>
**/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;



namespace _21193_21207
{   
    
    class Program
    {  
        static void Main(string[] args)
        {
            /// <summary> 
            /// É criada uma farmácia com um total de medicamentos que podem existir
            /// </summary>
            Farmacia farmaciaUnica = Farmacia.ObterInstanciaUnica();
            //Farmacia farmacia = new Farmacia("Farmacia1", 0);
            Farmaceutico farmaceutico = new Farmaceutico("Pedro Areias", 45, farmaciaUnica);
           

            /// <summary> 
            /// Menu inicial apresentado as seguintes opções
            /// </summary>
    
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
                        CamadaIntermedia.InserirMedicamento(farmaceutico);
                        break;
                    case "2":
                        CamadaIntermedia.RemoverMedicamento(farmaceutico);
                        break;
                    case "3":
                        CamadaIntermedia.MostrarMedicamentos(farmaceutico);
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
       
        
        

    }
}
