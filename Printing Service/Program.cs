using BL.Base;
using BL.Objects;
using Microsoft.Extensions.DependencyInjection;
using Printing_Service.Factory;

namespace Printing_Service
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //This is a provider for using services in project
            IServiceProvider serviceProvider = GetServices().BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            Application.Run(serviceProvider.GetRequiredService<ILoginFactory>().Create());
        }

        /// <summary>
        /// Get services for Dependency Injection provider
        /// </summary>
        /// <returns>IServiceCollection</returns>
        public static IServiceCollection GetServices()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddTransient<User>();

            services.AddSingleton<DBase>();
            services.AddSingleton<ILoginFactory, LoginFactory>();
            services.AddSingleton<IAdminFactory, AdminFactory>();
            services.AddSingleton<ICreateUserFactory, CreateUserFactory>();
            services.AddSingleton<IEditUserFactory, EditUserFactory>();
            
            return services;
        }
    }
}