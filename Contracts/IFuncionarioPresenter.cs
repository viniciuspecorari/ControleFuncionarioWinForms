using ControleFuncionario.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFuncionario.Contracts
{
    public interface IFuncionarioPresenter
    {
        public void CadastrarFuncionario();
        public object RecuperarFuncionarios();

        public void SetView(IControleFuncionario view);
    }
}
