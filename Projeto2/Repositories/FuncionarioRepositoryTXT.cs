using Projeto2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2.Repositories
{
    public class FuncionarioRepositoryTXT : FuncionarioRepository
    {
        public override void ExportarDados(Funcionario funcionario)
        {
            #region Definindo o nome e o local do arquivo

            var path = "c:\\temp\\funcionarios.txt";

            #endregion

            #region Gravando o conteudo do arquivo

            using (var streamWritter = new StreamWriter(path, true))
            {
                streamWritter.WriteLine($"ID DO FUNCIONÁRIO.........: {funcionario.Id}");
                streamWritter.WriteLine($"NOME......................: {funcionario.Nome}");
                streamWritter.WriteLine($"DATA DE NASCIMENTO........: {funcionario.DataNascimento.ToString("dd/MM/yyyy")}");
                streamWritter.WriteLine($"CPF.......................: {funcionario.Cpf}");
                streamWritter.WriteLine($"MATRICULA.................: {funcionario.Matricula}");
                streamWritter.WriteLine($"DATA DE ADMISSÃO..........: {funcionario.DataAdmissao.ToString("dd/MM/yyyy")}");
                streamWritter.WriteLine($"ID DO SETOR...............: {funcionario.Setor.Id}");
                streamWritter.WriteLine($"SIGLA DO SETOR............: {funcionario.Setor.Sigla}");
                streamWritter.WriteLine($"DESCRIÇÃO DO SETOR........: {funcionario.Setor.Descricao}");
                streamWritter.WriteLine("\n");

            }


           // utilizando o recurso "using" não é necessário salvar e fechar a conexão
          //  streamWritter.Flush(); // Salvar o arquivo
          //  streamWritter.Close(); // fechar o arquivo

            #endregion
        }
    }
}
