using DemoLibrary.Services;

namespace WinFormsUI;
public partial class Form2 : Form
{
    private readonly IMessages _messages;

    private string _runTimeMessage;

    private bool _requiredParametersHaveBeenPassedIn = false;

    public Form2(IMessages messages)
    {
        InitializeComponent();
        _messages = messages;       
    }

    public void PassRequiredParameters(string runTimeMessage)
    {
        _runTimeMessage = runTimeMessage;
        _requiredParametersHaveBeenPassedIn = true;
    }

    private void DisplayMessages()
    {
        this.labelMessage1.Text = _messages.MessageOne();
        this.labelMessage2.Text = _messages.MessageTwo();
        this.labelMessage3.Text = $"This message is passed at runtime : {_runTimeMessage}";
    }

    private void Form2_Load(object sender, EventArgs e)
    {
        if(_requiredParametersHaveBeenPassedIn == false)
        {
            TaskDialog.ShowDialog(this, new TaskDialogPage()
            {
                Text = "The required parameters for this form to work have not been passed in.",
                Heading = "Missing parameter values",
                Caption = "Error",
                Buttons = 
                {
                    TaskDialogButton.OK
                },
                Icon = TaskDialogIcon.Warning,
                //DefaultButton = TaskDialogButton.No
            });

            this.Enabled = false;
            return;
        }

        DisplayMessages();
    }
}
