namespace DemoLibrary.Services;

public class Messages : IMessages
{
    private readonly ISettings _settings;

    public Messages(ISettings settings)
    {
        _settings = settings;
    }

    public string MessageOne() => $"Message one : {_settings.GlobalSettings.MySettingOne}";

    public string MessageTwo() => $"Message two : {_settings.GlobalSettings.MySettingTwo}";
}
