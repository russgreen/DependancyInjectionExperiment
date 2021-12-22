using DemoLibrary.Services;

namespace WinFormsUI;
public partial class Form2 : Form
{
    private readonly IMessages _messages;

    public Form2(IMessages messages)
    {
        InitializeComponent();
        _messages = messages;

        DisplayMessages();
    }

    public void DisplayMessages(string runTimeMessage = "")
    {
        this.labelMessage1.Text = _messages.MessageOne();
        this.labelMessage2.Text = _messages.MessageTwo();
        this.labelMessage3.Text = $"This message is passed at runtime : {runTimeMessage}";
    }


}
