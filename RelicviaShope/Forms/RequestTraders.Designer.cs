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
        listBoxRequest = new ListBox();
        SuspendLayout();
        // 
        // listBox1
        // 
        listBoxRequest.BackColor = Color.FromArgb(56, 55, 64);
        listBoxRequest.BorderStyle = BorderStyle.None;
        listBoxRequest.Dock = DockStyle.Fill;
        listBoxRequest.Font = new Font("MS UI Gothic", 15.75F);
        listBoxRequest.ForeColor = Color.FromArgb(218, 220, 238);
        listBoxRequest.FormattingEnabled = true;
        listBoxRequest.Items.AddRange(new object[] { "sdfsdfsdf" });
        listBoxRequest.Location = new Point(0, 0);
        listBoxRequest.Name = "listBox1";
        listBoxRequest.Size = new Size(800, 450);
        listBoxRequest.TabIndex = 0;
        listBoxRequest.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        // 
        // RequestTraders
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(56, 55, 64);
        ClientSize = new Size(800, 450);
        Controls.Add(listBoxRequest);
        Name = "RequestTraders";
        Text = "RequestTraders";
        Load += RequestTraders_Load;
        ResumeLayout(false);
    }

    #endregion

    private ListBox listBoxRequest;
}