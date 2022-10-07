//Localização da classe dentro do projeto
using Projeto2.Controllers;

namespace Projeto2
{
    //definição da classe
    public class Program
    {
        //Método para executar o conteudo da classe
        //Ponto de atualização do projeto
        public static void Main(string[] args)
        {
            //instanciar a classe de controle
            var funcionarioController = new FuncionarioController();

            funcionarioController.CadastrarFuncionario();

            //pausar o prompt
            Console.ReadKey();
        }

    }
}
