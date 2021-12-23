using DemoLibrary.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WinFormsUI;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        string ConnectionString = "my connection string";

        //setup DI system
        var builder = new HostBuilder()
            .ConfigureServices((_, services) =>
            {
                services
                    .AddDemoServices(ConnectionString)
                    .AddTransient<FormMain>()
                    .AddTransient<Form1>()
                    .AddTransient<Form2>()
                    .AddTransient<Form4Factory>();

            });

        var host = builder.Build();
        using var scope = host.Services.CreateScope();

        var services = scope.ServiceProvider;


        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        var frm = services.GetRequiredService<FormMain>();
        Application.Run(frm);
    }
}