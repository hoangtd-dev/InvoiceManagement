using InvoiceManagement.Core.Interfaces.Repositories;
using InvoiceManagement.Core.Interfaces.Services;
using InvoiceManagement.Core.Services;
using InvoiceManagement.Infrastructure.Data;
using InvoiceManagement.Infrastructure.Repositories;
using InvoiceManagement.Presentation.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;

namespace InvoiceManagement
{
    static class Program
    {
        private static IServiceProvider _serviceProvider;

        [STAThread]
        static void Main()
        {            
            ApplicationConfiguration.Initialize();
            // Configure services
            var services = new ServiceCollection();
            ConfigureServices(services);

            _serviceProvider = services.BuildServiceProvider();

            // Show the main form
            var mainForm = _serviceProvider.GetRequiredService<MainForm>();

            Application.Run(mainForm);
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddTransient<MainForm>();

            // Register services
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IInvoiceService, InvoiceService>();

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IInvoiceRepository, InvoiceRepository>();

            // Register DbContext
            //services.AddDbContext<AppDbContext>(options =>
            //    options.UseSqlServer("YourConnectionString"));
        }
    }
}