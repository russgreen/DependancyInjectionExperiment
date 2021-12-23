using DemoLibrary.Services;
namespace WinFormsUI;
public partial class Form3 : Form
{
    private readonly IMessages _messages;
    private string _runTimeMessage;

    public Form3(string runTimeMessage, IMessages messages)
    {
        InitializeComponent();
        _runTimeMessage = runTimeMessage;
        _messages = messages;

        DisplayMessages();
    }

    private void DisplayMessages()
    {
        this.labelMessage1.Text = _messages.MessageOne();
        this.labelMessage2.Text = _messages.MessageTwo();
        this.labelMessage3.Text = $"This message is passed at runtime : {_runTimeMessage}";
    }
}
