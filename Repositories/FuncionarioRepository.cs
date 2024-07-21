using ControleFuncionario.Contracts;
using ControleFuncionario.Data;
using ControleFuncionario.Model.Dto;
using ControleFuncionario.Model.Entities;
using Microsoft.EntityFrameworkCore;


namespace ControleFuncionario.Repositories
{
    public class FuncionarioRepository(ControleFuncDbContext dbContext) : IFuncionarioRepository
    {
        private readonly ControleFuncDbContext _dbContext = dbContext;
        private readonly DbSet<Funcionario> _dbSet = dbContext.Set<Funcionario>();

        public void Delete(Guid id)
        {
            var funcionario = _dbSet.Find(id);

            if (funcionario is not null)
            {
                _dbSet.Remove(funcionario);
                _dbContext.SaveChanges();
            }
            else
            {
                throw new Exception("Usuário não encontrado");
            }
        }

        public IEnumerable<Funcionario> GetAll()
        {
            return _dbSet.ToList();
        }

        public Funcionario GetBydId(Guid id)
        {
            return _dbSet.Find(id);
        }

        public void Save(Funcionario funcionario)
        {
            if (funcionario.Id != default)
            {
                _dbSet.Entry(funcionario).State = EntityState.Modified;
                _dbSet.Update(funcionario);
            }
            else
            {
                _dbSet.Add(funcionario);
            }
            _dbContext.SaveChanges();
        }

        public void Update(FuncionarioUpdate funcionario, Guid id)
        {
            var funcionarioUpdated = _dbSet.Find(id);

            if (funcionarioUpdated is not null)
            {
                funcionarioUpdated.Name = funcionario.Name ?? funcionarioUpdated.Name;
                funcionarioUpdated.DateOfBirth = funcionario.DateOfBirth ?? funcionarioUpdated.DateOfBirth;
                funcionarioUpdated.Function = funcionario.Function ?? funcionarioUpdated.Function;
                _dbContext.SaveChanges();
            }
            else
            {
                throw new Exception("Usuário não encontrado");
            }
        }
    }
}
