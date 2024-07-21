using ControleFuncionario.Contracts;
using ControleFuncionario.Data;
using ControleFuncionario.Presenter;
using ControleFuncionario.Repositories;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using ControleFuncionario.View;

namespace ControleFuncionario
{
    internal static class Program
    {
        private static readonly IServiceCollection _services = new ServiceCollection();

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            ConfigureServices();

            using var serviceProvider = _services.BuildServiceProvider();
            var indexForm = serviceProvider.GetRequiredService<IControleFuncionario>();
            
            Application.Run(indexForm as Form);
        }

        
        static void ConfigureServices()
        {
            _services.AddDbContext<ControleFuncDbContext>();
            _services.AddScoped<IFuncionarioRepository, FuncionarioRepository>();
            _services.AddScoped<IFuncionarioPresenter, FuncionarioPresenter>();
            _services.AddScoped<IControleFuncionario, View.ControleFuncionario>();
        }

    }
}