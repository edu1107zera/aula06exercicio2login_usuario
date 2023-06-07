using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula06ex2
{
    class Program
    {
        static void Main(string[] args)
        {


            string cadalogin;
            string senhalog;
            string senha = "edu123";
            string user = "eduzera";
            string caduser;
            
            
            
          



            Console.WriteLine("\nBem-vindo ao Eduzito's BANK.");
            Console.WriteLine("\nopçoes:");

            Console.WriteLine("1-cadastar");
            Console.WriteLine("2-login");

            Console.Write("\nDigite uma opçao:");
            cadalogin = Console.ReadLine();

            if ((cadalogin == "1") || (cadalogin == "2"))
            {
                if (cadalogin == "1")
                {   
                    Console.WriteLine("\n---Cadastro de novo usuario:");
                    Console.Write("- Digite o novo usuario: ");
                    user = Console.ReadLine();
                    Console.Write("- Digite uma senha: ");
                    senha = Console.ReadLine();

                }
                
                Console.WriteLine("\n-----login de usuario-----");
                Console.Write("- Para continuar,digite o usuario cadastrado: ");
                caduser = Console.ReadLine();

                if (user == caduser)
                {
                    Console.Write("- Digite sua senha: ");
                    senhalog = Console.ReadLine();

                    if (senha == senhalog)
                    {
                        Console.WriteLine("  \n   ///LOGIN REALIZADO///");
                    }
                    else
                    {
                        Console.WriteLine("SENHA INCORRETA");
                        Main(null);
                        return;
                    }

                }
                else
                {
                    Console.WriteLine("USUARIO INCORRETO");
                    Main(null);
                    return;
                }
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("\n //Opçao invalida,digite apenas 1 ou 2//");
                Main(null);
                return;

            }


        }
    }
}

