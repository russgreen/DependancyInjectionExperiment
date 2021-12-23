using DemoLibrary.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace WinFormsUI;

public partial class FormMain : Krypton.Toolkit.KryptonForm
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ISettings _settings;
    private readonly Form4Factory _form4Factory;

    public FormMain(IServiceProvider serviceProvider,
                    ISettings settings,
                    Form4Factory form4Factory)
    {
        InitializeComponent();

        var informationVersion = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;
        this.Text = $"Dependancy Injection Experiment {informationVersion}";

        _serviceProvider = serviceProvider;
        _settings = settings;
        _form4Factory = form4Factory;
    }

    private void kryptonRibbonGroupButtonForm1_Click(object sender, EventArgs e)
    {
        Form frm = _serviceProvider.GetRequiredService<Form1>();
        LoadFormIntoPanel(frm);
    }

    private void kryptonRibbonGroupButtonForm2_Click(object sender, EventArgs e)
    {
        Form2 frm = _serviceProvider.GetRequiredService<Form2>();
        frm.PassRequiredParameters($"message created on {DateTime.UtcNow.ToLongTimeString()}");

        LoadFormIntoPanel((Form)frm);
    }

    private void kryptonRibbonGroupButtonForm2a_Click(object sender, EventArgs e)
    {
        Form frm = _serviceProvider.GetRequiredService<Form2>();
        LoadFormIntoPanel(frm);
    }

    private void kryptonRibbonGroupButtonForm3_Click(object sender, EventArgs e)
    {
        Form frm = new Form3($"message created on {DateTime.UtcNow.ToLongTimeString()}",
            _serviceProvider.GetRequiredService<IMessages>());
        LoadFormIntoPanel(frm);
    }

    private void kryptonRibbonGroupButtonForm4_Click(object sender, EventArgs e)
    {
        Form frm = _form4Factory.Create($"message created on {DateTime.UtcNow.ToLongTimeString()}");
        LoadFormIntoPanel(frm);
    }

    private void kryptonRibbonGroupButtonReloadSettings_Click(object sender, EventArgs e)
    {
        _settings.ReloadSettings();
    }

    private void kryptonContextMenuItemClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void LoadFormIntoPanel(Form frm)//, ref Panel pnl)
    {
        //this.kryptonPanelMain.Controls.Clear();
        foreach (Form form in this.kryptonPanelMain.Controls)
        {
            form.Close();
        }

        frm.FormBorderStyle = FormBorderStyle.None;
        frm.TopLevel = false;
        frm.Dock = DockStyle.Fill;
        this.kryptonPanelMain.Controls.Add(frm);
        frm.Show();
        this.Focus();
    }


}
