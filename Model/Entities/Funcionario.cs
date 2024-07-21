namespace ControleFuncionario.Model.Entities
{
    public class Funcionario
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Function { get; set; }
    }
}
