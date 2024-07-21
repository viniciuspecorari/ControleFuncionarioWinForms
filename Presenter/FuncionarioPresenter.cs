using ControleFuncionario.Contracts;
using ControleFuncionario.Model.Entities;
using ControleFuncionario.View;

namespace ControleFuncionario.Presenter
{
    public class FuncionarioPresenter(IFuncionarioRepository repository) : IFuncionarioPresenter
    {
        private IControleFuncionario _view;
        private readonly IFuncionarioRepository _repository = repository;

        public void SetView(IControleFuncionario view) { _view = view; }

        public void CadastrarFuncionario()
        {
            var funcionario = new Funcionario
            {
                Name = _view.Name,
                Function = _view.Function,
                DateOfBirth = _view.DateOfBirth,
            };

            _repository.Save(funcionario);
        }

        public object RecuperarFuncionarios()
        {
            return _repository.GetAll();
        }
    }
}
