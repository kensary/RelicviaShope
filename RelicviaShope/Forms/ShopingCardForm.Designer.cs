namespace RelicviaShope;

partial class ShopingCardForm
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
        panel1 = new Panel();
        button2 = new Button();
        button1 = new Button();
        panel2 = new Panel();
        listBox1 = new ListBox();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.Gray;
        panel1.Controls.Add(button2);
        panel1.Controls.Add(button1);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 340);
        panel1.Name = "panel1";
        panel1.Size = new Size(800, 110);
        panel1.TabIndex = 0;
        // 
        // button2
        // 
        button2.Anchor = AnchorStyles.Left;
        button2.BackColor = Color.FromArgb(255, 128, 128);
        button2.Location = new Point(33, 36);
        button2.Name = "button2";
        button2.Size = new Size(145, 50);
        button2.TabIndex = 1;
        button2.Text = "очистить корзину";
        button2.UseVisualStyleBackColor = false;
        button2.Click += button2_Click;
        // 
        // button1
        // 
        button1.Anchor = AnchorStyles.Right;
        button1.BackColor = Color.FromArgb(128, 255, 128);
        button1.Location = new Point(623, 36);
        button1.Name = "button1";
        button1.Size = new Size(145, 50);
        button1.TabIndex = 0;
        button1.Text = "купить";
        button1.UseVisualStyleBackColor = false;
        // 
        // panel2
        // 
        panel2.BackColor = Color.FromArgb(224, 224, 224);
        panel2.Controls.Add(listBox1);
        panel2.Dock = DockStyle.Fill;
        panel2.Location = new Point(0, 0);
        panel2.Name = "panel2";
        panel2.Size = new Size(800, 340);
        panel2.TabIndex = 1;
        // 
        // listBox1
        // 
        listBox1.BackColor = Color.Silver;
        listBox1.Dock = DockStyle.Fill;
        listBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        listBox1.FormattingEnabled = true;
        listBox1.Location = new Point(0, 0);
        listBox1.Name = "listBox1";
        listBox1.Size = new Size(800, 340);
        listBox1.TabIndex = 0;
        // 
        // ShopingCardForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Name = "ShopingCardForm";
        Text = "ShopingCardForm";
        Load += ShopingCardForm_Load;
        panel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Button button2;
    private Button button1;
    private Panel panel2;
    private ListBox listBox1;
}