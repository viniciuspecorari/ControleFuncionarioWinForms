using ControleFuncionario.Model.Entities;

namespace ControleFuncionario.Model.Dto
{
    public record FuncionarioUpdate(string? Name, DateTime? DateOfBirth, string? Function)
    {
        public static implicit operator FuncionarioUpdate(Funcionario e)
        {
            return new FuncionarioUpdate(e.Name, e.DateOfBirth, e.Function);
        }
    }
}
