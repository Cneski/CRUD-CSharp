using System;
using System.Windows.Forms;
using System.Reflection;
using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using Autofac;

namespace EstoqueMercado
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<RepositoryBancoDados>().As<IRepository>();
            builder.RegisterType<TelaInicial>();
            var container = builder.Build();
            var serviceProvider = CreateServices();

            using (var scope = serviceProvider.CreateScope())
            {
                UpdateDatabase(scope.ServiceProvider);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var telaInicial = container.Resolve<TelaInicial>();
            telaInicial.ShowDialog();
        }

        private static IServiceProvider CreateServices()
        {
             string conexao = "";
            const string connectionString = "ConexaoBancoDados";
            conexao = ConfigurationManager.ConnectionStrings[connectionString].ConnectionString;
            return new ServiceCollection()
                .AddFluentMigratorCore()
                .ConfigureRunner(rb => rb
                    .AddSqlServer()
                    .WithGlobalConnectionString(conexao)
                    .ScanIn(Assembly.GetExecutingAssembly()).For.Migrations())
                .AddLogging(lb => lb.AddFluentMigratorConsole())
                .BuildServiceProvider(false);
        }

        private static void UpdateDatabase(IServiceProvider serviceProvider)
        {
            var runner = serviceProvider.GetRequiredService<IMigrationRunner>();
            runner.MigrateUp();
        }

    }
}
