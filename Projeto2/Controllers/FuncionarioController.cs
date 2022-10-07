using Projeto2.Entities;
using Projeto2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2.Controllers
{
    public class FuncionarioController
    {
        public void CadastrarFuncionario()
        {
            try
            {
                Console.WriteLine("\n *** CADASTRO DE FUNCIONÁRIO *** \n");

                #region Capturar os dados do funcionario

                var funcionario = new Funcionario();

                funcionario.Id = Guid.NewGuid();

                Console.Write("NOME DO FUNCIONÁRIO..........: ");
                funcionario.Nome = Console.ReadLine();

                Console.Write("DATA DE NASCIMENTO...........: ");
                funcionario.DataNascimento =DateTime.Parse(Console.ReadLine());

                Console.Write("CPF..........................: ");
                funcionario.Cpf = Console.ReadLine();

                Console.Write("MATRICULA....................: ");
                funcionario.Matricula = Console.ReadLine();

                Console.Write("DATA DE ADMISSÃO.............: ");
                funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());
                #endregion

                #region Capturar os dados do setor do funcionario

                funcionario.Setor = new Setor();

                funcionario.Setor.Id = Guid.NewGuid();

                Console.Write("SIGLA DO SETOR...............: ");
                funcionario.Setor.Sigla = Console.ReadLine();

                Console.Write("DESCRIÇÃO DO SETOR...........: ");
                funcionario.Setor.Descricao = Console.ReadLine();

                #endregion

                #region Exportando os dados para arquivo

                Console.Write("\nINFORME (1)CSV OU (2)TXT: ");
                var opcao = int.Parse(Console.ReadLine());

                //criando um objeto da classe abstrata, mas sem instancia-lo
                FuncionarioRepository funcionarioRepository = null;

                switch(opcao)
                {
                    case 1: //Csv
                        funcionarioRepository = new FuncionarioRepositoryCSV();
                        break;

                    case 2: //Txt
                        funcionarioRepository = new FuncionarioRepositoryTXT();
                        break;

                    default: //Nenhum dos anteriores
                        Console.WriteLine("\nFormato Inválido");
                        break;
                }

                //Verificando se o objeto 'funcionarioRepository' não é null
                if(funcionarioRepository != null)
                {
                    //Gravando dados do funcionario em arquivo
                    funcionarioRepository.ExportarDados(funcionario);
                    Console.WriteLine("\nDados gravados com sucesso!");
                }
                #endregion
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nFalha ao cadatrar: {e.Message}");
            }
        }
    }
}
