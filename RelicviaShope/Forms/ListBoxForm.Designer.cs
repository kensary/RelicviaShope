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
        listBox1 = new ListBox();
        SuspendLayout();
        // 
        // listBox1
        // 
        listBox1.BackColor = Color.Silver;
        listBox1.Dock = DockStyle.Fill;
        listBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        listBox1.FormattingEnabled = true;
        listBox1.Location = new Point(0, 0);
        listBox1.Name = "listBox1";
        listBox1.Size = new Size(800, 450);
        listBox1.TabIndex = 1;
        listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
        // 
        // ListBoxForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(listBox1);
        Name = "ListBoxForm";
        Text = "ListBoxForm";
        Load += ListBoxForm_Load;
        ResumeLayout(false);
    }

    #endregion

    private ListBox listBox1;
}