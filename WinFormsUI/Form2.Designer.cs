namespace WinFormsUI;

partial class Form2
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
            this.labelMessage2 = new System.Windows.Forms.Label();
            this.labelMessage1 = new System.Windows.Forms.Label();
            this.labelMessage3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Form2";
            // 
            // labelMessage2
            // 
            this.labelMessage2.AutoSize = true;
            this.labelMessage2.Location = new System.Drawing.Point(12, 101);
            this.labelMessage2.Name = "labelMessage2";
            this.labelMessage2.Size = new System.Drawing.Size(84, 15);
            this.labelMessage2.TabIndex = 2;
            this.labelMessage2.Text = "labelMessage2";
            // 
            // labelMessage1
            // 
            this.labelMessage1.AutoSize = true;
            this.labelMessage1.Location = new System.Drawing.Point(12, 59);
            this.labelMessage1.Name = "labelMessage1";
            this.labelMessage1.Size = new System.Drawing.Size(84, 15);
            this.labelMessage1.TabIndex = 3;
            this.labelMessage1.Text = "labelMessage1";
            // 
            // labelMessage3
            // 
            this.labelMessage3.AutoSize = true;
            this.labelMessage3.Location = new System.Drawing.Point(12, 142);
            this.labelMessage3.Name = "labelMessage3";
            this.labelMessage3.Size = new System.Drawing.Size(84, 15);
            this.labelMessage3.TabIndex = 2;
            this.labelMessage3.Text = "labelMessage3";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMessage3);
            this.Controls.Add(this.labelMessage2);
            this.Controls.Add(this.labelMessage1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label label1;
    private Label labelMessage2;
    private Label labelMessage1;
    private Label labelMessage3;
}
