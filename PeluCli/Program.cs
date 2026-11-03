using Microsoft.Extensions.DependencyInjection;
using PeluCore.Data;
using PeluCore.Models;
using PeluCore.Repositories;
using System;

namespace PeluCli
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();


            // reistrar dependencias
            var services = new ServiceCollection();

            services.AddScoped<AplicationDbContext>();

            // repositorys
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<TurnoRepository>();
            services.AddScoped<ReporteRepository>();

            // forms
            services.AddTransient<FormMenu>();
            services.AddTransient<FormCliente>();
            services.AddTransient <FormPromociones>();
            services.AddTransient<FormReportes>();
            services.AddTransient<FormTurno>();

            // contruir y ejecutar
            var provider = services.BuildServiceProvider();
            

            Application.Run(provider.GetRequiredService<FormMenu>());
        }
    }
}