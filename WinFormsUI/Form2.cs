using DemoLibrary.Services;

namespace WinFormsUI;
public partial class Form2 : Form
{
    private readonly IMessages _messages;

    public Form2(IMessages messages)
    {
        InitializeComponent();
        _messages = messages;

        this.labelMessage1.Text = _messages.MessageOne();
        this.labelMessage2.Text = _messages.MessageTwo();
    }
}
