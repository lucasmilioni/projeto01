using Projeto2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2.Repositories
{
    public class FuncionarioRepositoryCSV : FuncionarioRepository
    {
        public override void ExportarDados(Funcionario funcionario)
        {
            #region Definindo nome e local do arquivo

            var path = "c:\\temp\\funcionarios.csv";

            #endregion

            #region Gravando o conteudo do arquivo

            using (var streamWritter = new StreamWriter(path, true))
            {
                var texto = $"{funcionario.Id};"
                          + $"{funcionario.Nome};"
                          + $"{funcionario.DataNascimento.ToString("dd/MM/yyyy")};"
                          + $"{funcionario.Cpf};"
                          + $"{funcionario.Matricula};"
                          + $"{funcionario.DataAdmissao.ToString("dd/MM/yyyy")};"
                          + $"{funcionario.Setor.Sigla};"
                          + $"{funcionario.Setor.Descricao}";
                
                streamWritter.WriteLine(texto);
                #endregion
            }
        }
    }
}
