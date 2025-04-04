namespace RelicviaShope.Forms;

partial class RequestTraders
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
        listBox1 = new ListBox();
        SuspendLayout();
        // 
        // listBox1
        // 
        listBox1.BackColor = Color.FromArgb(56, 55, 64);
        listBox1.BorderStyle = BorderStyle.None;
        listBox1.Dock = DockStyle.Fill;
        listBox1.Font = new Font("MS UI Gothic", 15.75F);
        listBox1.ForeColor = Color.FromArgb(218, 220, 238);
        listBox1.FormattingEnabled = true;
        listBox1.Items.AddRange(new object[] { "sdfsdfsdf" });
        listBox1.Location = new Point(0, 0);
        listBox1.Name = "listBox1";
        listBox1.Size = new Size(800, 450);
        listBox1.TabIndex = 0;
        listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        // 
        // RequestTraders
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(56, 55, 64);
        ClientSize = new Size(800, 450);
        Controls.Add(listBox1);
        Name = "RequestTraders";
        Text = "RequestTraders";
        Load += RequestTraders_Load;
        ResumeLayout(false);
    }

    #endregion

    private ListBox listBox1;
}