using DemoLibrary.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI;
public partial class Form4 : Form
{
    private readonly IMessages _messages;
    private string _runTimeMessage;

    public Form4(string runTimeMessage, IMessages messages)
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
