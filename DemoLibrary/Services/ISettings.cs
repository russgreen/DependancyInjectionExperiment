using DemoLibrary.Models;

namespace DemoLibrary.Services;

public interface ISettings
{
    SettingsModel GlobalSettings { get; }

    void ReloadSettings();
}