using Projeto2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2.Repositories
{
    public abstract class FuncionarioRepository
    {
        #region Métodos abstratos

        public abstract void ExportarDados(Funcionario funcionario);

        #endregion


    }
}
