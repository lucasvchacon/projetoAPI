using System;

namespace programa1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Lista de Tarefas");

            Console.WriteLine("Menu:\n c - Cadastrar Tarefa");
            Console.WriteLine("m- Mudar o status de uma tarefa"); 
            Console.WriteLine("e- Excluir uma tarefa"); 
            Console.WriteLine("s- Sair da aplicação ");


            Console.WriteLine("Escolha uma letra");
            char escolha = char.Parse(Console.ReadLine());

            //int num = int.Parse.Console.ReadLine();


            

                switch(escolha)
                {
                    case 'c':
                         Console.WriteLine("c- Cadastrar Tarefa");
                        break;
                    case 'l':
                        Console.WriteLine("2- Listar as Tarefas Cadastradas");
                        break; 
                    case 'm':
                        Console.WriteLine("3- Mudar o status de uma tarefa");
                        break;
                    case 'e':
                        Console.WriteLine("4- Excluir uma tarefa");
                        break;
                    case 's':
                        Console.WriteLine("9- Sair");
                        break; 
                    default:
                        break; 
                }

                Console.WriteLine($"A letra digitado foi: {escolha}");     

        }
    }
}


 // string nome = Console.ReadLine();
          //  Console.WriteLine("o nome digitado foi: "+nome);
          //  Console.WriteLine($"o nome digitado foi: {nome}");
          //int valor = Convert.ToInt32("num"); 
           //default:
                  //  Console.WriteLine("Sair");
                   // break;