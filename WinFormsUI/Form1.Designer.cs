namespace WinFormsUI;

partial class Form1
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.label1 = new System.Windows.Forms.Label();
            this.labelMessage1 = new System.Windows.Forms.Label();
            this.labelMessage2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form1";
            // 
            // labelMessage1
            // 
            this.labelMessage1.AutoSize = true;
            this.labelMessage1.Location = new System.Drawing.Point(12, 62);
            this.labelMessage1.Name = "labelMessage1";
            this.labelMessage1.Size = new System.Drawing.Size(84, 15);
            this.labelMessage1.TabIndex = 1;
            this.labelMessage1.Text = "labelMessage1";
            // 
            // labelMessage2
            // 
            this.labelMessage2.AutoSize = true;
            this.labelMessage2.Location = new System.Drawing.Point(12, 104);
            this.labelMessage2.Name = "labelMessage2";
            this.labelMessage2.Size = new System.Drawing.Size(84, 15);
            this.labelMessage2.TabIndex = 1;
            this.labelMessage2.Text = "labelMessage2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMessage2);
            this.Controls.Add(this.labelMessage1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label label1;
    private Label labelMessage1;
    private Label labelMessage2;
}
