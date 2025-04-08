namespace RelicviaShope;

partial class ListBoxForm
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
        listBoxTovars = new ListBox();
        SuspendLayout();
        // 
        // listBox1
        // 
        listBoxTovars.BackColor = Color.FromArgb(78, 79, 90);
        listBoxTovars.BorderStyle = BorderStyle.None;
        listBoxTovars.Dock = DockStyle.Fill;
        listBoxTovars.Font = new Font("MS UI Gothic", 15.75F);
        listBoxTovars.ForeColor = Color.FromArgb(218, 220, 238);
        listBoxTovars.FormattingEnabled = true;
        listBoxTovars.Location = new Point(0, 0);
        listBoxTovars.Name = "listBox1";
        listBoxTovars.Size = new Size(800, 450);
        listBoxTovars.TabIndex = 1;
        listBoxTovars.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
        // 
        // ListBoxForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(78, 79, 90);
        ClientSize = new Size(800, 450);
        Controls.Add(listBoxTovars);
        FormBorderStyle = FormBorderStyle.None;
        Name = "ListBoxForm";
        Text = "ListBoxForm";
        Load += ListBoxForm_Load;
        ResumeLayout(false);
    }

    #endregion

    private ListBox listBoxTovars;
}