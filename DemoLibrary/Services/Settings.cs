using DemoLibrary.DataAccess;
using DemoLibrary.Models;

namespace DemoLibrary.Services;

public class Settings : ISettings
{
    private readonly IDataConnection _connection;

    public SettingsModel GlobalSettings { get; private set; }

    public Settings(IDataConnection connection)
    {
        _connection = connection;

        GlobalSettings = GetSettings();
    }

    public void ReloadSettings()
    {
        GlobalSettings = GetSettings();
    }

    private SettingsModel GetSettings()
    {
        //var settings = _connection.LoadData<SettingsModel, dynamic>("spName", null).FirstOrDefault();
        SettingsModel settings = new SettingsModel
        {
            MySettingOne = $"My setting one loaded at {DateTime.UtcNow.ToLongTimeString()}",
            MySettingTwo = $"My setting two loaded at {DateTime.UtcNow.ToLongTimeString()}"
        };

        return settings;
    }
}
