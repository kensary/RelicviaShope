namespace RelicviaShope;

partial class Register
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
        panel2 = new Panel();
        label1 = new Label();
        linkLabel1 = new LinkLabel();
        textBox2 = new TextBox();
        textBox1 = new TextBox();
        loginButton = new Button();
        panel3 = new Panel();
        textBox3 = new TextBox();
        panel1 = new Panel();
        panel3.SuspendLayout();
        SuspendLayout();
        // 
        // panel2
        // 
        panel2.BackColor = Color.FromArgb(76, 74, 86);
        panel2.Dock = DockStyle.Left;
        panel2.Location = new Point(0, 0);
        panel2.Name = "panel2";
        panel2.Size = new Size(188, 450);
        panel2.TabIndex = 9;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
        label1.ForeColor = Color.FromArgb(218, 220, 238);
        label1.Location = new Point(247, 71);
        label1.Name = "label1";
        label1.Size = new Size(309, 27);
        label1.TabIndex = 11;
        label1.Text = "регистрация";
        label1.Click += label1_Click;
        // 
        // linkLabel1
        // 
        linkLabel1.Anchor = AnchorStyles.Top;
        linkLabel1.AutoSize = true;
        linkLabel1.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        linkLabel1.ForeColor = Color.FromArgb(218, 220, 238);
        linkLabel1.LinkColor = Color.FromArgb(218, 220, 238);
        linkLabel1.Location = new Point(355, 356);
        linkLabel1.Name = "linkLabel1";
        linkLabel1.Size = new Size(87, 16);
        linkLabel1.TabIndex = 10;
        linkLabel1.TabStop = true;
        linkLabel1.Text = "назад";
        linkLabel1.LinkClicked += linkLabel1_LinkClicked;
        linkLabel1.Click += label1_Click;
        // 
        // textBox2
        // 
        textBox2.Anchor = AnchorStyles.Top;
        textBox2.BackColor = Color.FromArgb(78, 79, 90);
        textBox2.BorderStyle = BorderStyle.None;
        textBox2.Font = new Font("MS UI Gothic", 15.75F);
        textBox2.ForeColor = Color.FromArgb(218, 220, 238);
        textBox2.Location = new Point(236, 213);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(331, 21);
        textBox2.TabIndex = 9;
        textBox2.Text = "пароль";
        // 
        // textBox1
        // 
        textBox1.Anchor = AnchorStyles.Top;
        textBox1.BackColor = Color.FromArgb(78, 79, 90);
        textBox1.BorderStyle = BorderStyle.None;
        textBox1.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        textBox1.ForeColor = Color.FromArgb(218, 220, 238);
        textBox1.Location = new Point(236, 162);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(331, 21);
        textBox1.TabIndex = 8;
        textBox1.Text = "логин";
        // 
        // loginButton
        // 
        loginButton.Anchor = AnchorStyles.Top;
        loginButton.BackColor = Color.FromArgb(78, 79, 90);
        loginButton.FlatStyle = FlatStyle.Popup;
        loginButton.Font = new Font("MS UI Gothic", 15.75F);
        loginButton.ForeColor = Color.FromArgb(218, 220, 238);
        loginButton.Location = new Point(236, 305);
        loginButton.Name = "loginButton";
        loginButton.Size = new Size(331, 35);
        loginButton.TabIndex = 7;
        loginButton.Text = "продолжить";
        loginButton.UseVisualStyleBackColor = false;
        loginButton.Click += loginButton_Click;
        // 
        // panel3
        // 
        panel3.BackColor = Color.FromArgb(56, 55, 64);
        panel3.Controls.Add(textBox3);
        panel3.Controls.Add(label1);
        panel3.Controls.Add(linkLabel1);
        panel3.Controls.Add(textBox2);
        panel3.Controls.Add(textBox1);
        panel3.Controls.Add(loginButton);
        panel3.Dock = DockStyle.Fill;
        panel3.Location = new Point(0, 0);
        panel3.Name = "panel3";
        panel3.Size = new Size(612, 450);
        panel3.TabIndex = 10;
        panel3.Paint += panel3_Paint;
        // 
        // textBox3
        // 
        textBox3.Anchor = AnchorStyles.Top;
        textBox3.BackColor = Color.FromArgb(78, 79, 90);
        textBox3.BorderStyle = BorderStyle.None;
        textBox3.Font = new Font("MS UI Gothic", 15.75F);
        textBox3.ForeColor = Color.FromArgb(218, 220, 238);
        textBox3.Location = new Point(236, 258);
        textBox3.Name = "textBox3";
        textBox3.Size = new Size(331, 21);
        textBox3.TabIndex = 12;
        textBox3.Text = "повтор пароля";
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(76, 74, 86);
        panel1.Dock = DockStyle.Right;
        panel1.Location = new Point(612, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(188, 450);
        panel1.TabIndex = 8;
        // 
        // Register
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(panel2);
        Controls.Add(panel3);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Name = "Register";
        Text = "Регистрация";
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Panel panel2;
    private Label label1;
    private LinkLabel linkLabel1;
    private TextBox textBox2;
    private TextBox textBox1;
    private Button loginButton;
    private Panel panel3;
    private Panel panel1;
    private TextBox textBox3;
}