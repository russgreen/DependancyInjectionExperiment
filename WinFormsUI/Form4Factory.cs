using DemoLibrary.Services;
using Microsoft.Extensions.DependencyInjection;

namespace WinFormsUI;

public class Form4Factory
{
    private readonly IServiceProvider _serviceProvider;

    public Form4Factory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public Form4 Create(string runTimeMessage)
    {
        IMessages messages = (IMessages)_serviceProvider.GetRequiredService(typeof(IMessages));
        return new Form4(runTimeMessage, messages);
    }

}
