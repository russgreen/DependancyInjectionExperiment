namespace WinFormsUI;

partial class FormMain
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.kryptonRibbon1 = new Krypton.Ribbon.KryptonRibbon();
            this.kryptonContextMenuItemClose = new Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonRibbonTab1 = new Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup1 = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple1 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.kryptonRibbonGroupButtonForm1 = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupButtonForm2 = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroup2 = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple2 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.kryptonRibbonGroupButtonReloadSettings = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonPanelMain = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelMain)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 568);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(950, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // kryptonRibbon1
            // 
            this.kryptonRibbon1.InDesignHelperMode = true;
            this.kryptonRibbon1.Name = "kryptonRibbon1";
            this.kryptonRibbon1.PaletteMode = Krypton.Toolkit.PaletteMode.Office365White;
            this.kryptonRibbon1.QATLocation = Krypton.Ribbon.QATLocation.Hidden;
            this.kryptonRibbon1.RibbonAppButton.AppButtonMenuItems.AddRange(new Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItemClose});
            this.kryptonRibbon1.RibbonTabs.AddRange(new Krypton.Ribbon.KryptonRibbonTab[] {
            this.kryptonRibbonTab1});
            this.kryptonRibbon1.SelectedTab = this.kryptonRibbonTab1;
            this.kryptonRibbon1.Size = new System.Drawing.Size(950, 115);
            this.kryptonRibbon1.TabIndex = 1;
            // 
            // kryptonContextMenuItemClose
            // 
            this.kryptonContextMenuItemClose.Text = "Close";
            this.kryptonContextMenuItemClose.Click += new System.EventHandler(this.kryptonContextMenuItemClose_Click);
            // 
            // kryptonRibbonTab1
            // 
            this.kryptonRibbonTab1.Groups.AddRange(new Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup1,
            this.kryptonRibbonGroup2});
            this.kryptonRibbonTab1.Text = "Main Tab";
            // 
            // kryptonRibbonGroup1
            // 
            this.kryptonRibbonGroup1.DialogBoxLauncher = false;
            this.kryptonRibbonGroup1.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple1});
            this.kryptonRibbonGroup1.TextLine1 = "Forms";
            // 
            // kryptonRibbonGroupTriple1
            // 
            this.kryptonRibbonGroupTriple1.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.kryptonRibbonGroupButtonForm1,
            this.kryptonRibbonGroupButtonForm2});
            // 
            // kryptonRibbonGroupButtonForm1
            // 
            this.kryptonRibbonGroupButtonForm1.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroupButtonForm1.ImageLarge")));
            this.kryptonRibbonGroupButtonForm1.TextLine1 = "Form1";
            this.kryptonRibbonGroupButtonForm1.Click += new System.EventHandler(this.kryptonRibbonGroupButtonForm1_Click);
            // 
            // kryptonRibbonGroupButtonForm2
            // 
            this.kryptonRibbonGroupButtonForm2.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroupButtonForm2.ImageLarge")));
            this.kryptonRibbonGroupButtonForm2.TextLine1 = "Form2";
            this.kryptonRibbonGroupButtonForm2.Click += new System.EventHandler(this.kryptonRibbonGroupButtonForm2_Click);
            // 
            // kryptonRibbonGroup2
            // 
            this.kryptonRibbonGroup2.DialogBoxLauncher = false;
            this.kryptonRibbonGroup2.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple2});
            this.kryptonRibbonGroup2.TextLine1 = "Settings";
            // 
            // kryptonRibbonGroupTriple2
            // 
            this.kryptonRibbonGroupTriple2.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.kryptonRibbonGroupButtonReloadSettings});
            // 
            // kryptonRibbonGroupButtonReloadSettings
            // 
            this.kryptonRibbonGroupButtonReloadSettings.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroupButtonReloadSettings.ImageLarge")));
            this.kryptonRibbonGroupButtonReloadSettings.TextLine1 = "Reload";
            this.kryptonRibbonGroupButtonReloadSettings.TextLine2 = "Settings";
            this.kryptonRibbonGroupButtonReloadSettings.Click += new System.EventHandler(this.kryptonRibbonGroupButtonReloadSettings_Click);
            // 
            // kryptonPanelMain
            // 
            this.kryptonPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanelMain.Location = new System.Drawing.Point(0, 115);
            this.kryptonPanelMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.kryptonPanelMain.Name = "kryptonPanelMain";
            this.kryptonPanelMain.Size = new System.Drawing.Size(950, 453);
            this.kryptonPanelMain.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 590);
            this.Controls.Add(this.kryptonPanelMain);
            this.Controls.Add(this.kryptonRibbon1);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }


    #endregion

    private StatusStrip statusStrip1;
    private Krypton.Ribbon.KryptonRibbon kryptonRibbon1;
    private Krypton.Toolkit.KryptonPanel kryptonPanelMain;
    private Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItemClose;
    private Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab1;
    private Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup1;
    private Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup2;
    private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple1;
    private Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButtonForm1;
    private Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButtonForm2;
    private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple2;
    private Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButtonReloadSettings;
}
