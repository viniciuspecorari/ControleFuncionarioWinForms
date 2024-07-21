using ControleFuncionario.Model.Dto;
using ControleFuncionario.Model.Entities;

namespace ControleFuncionario.Contracts
{
    public interface IFuncionarioRepository
    {
        IEnumerable<Funcionario> GetAll();
        Funcionario GetBydId(Guid id);
        void Save(Funcionario funcionario);
        void Delete(Guid id);
        void Update(FuncionarioUpdate funcionario, Guid id);
    }
}
