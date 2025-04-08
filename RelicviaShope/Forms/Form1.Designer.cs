namespace RelicviaShope;

partial class Form1
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
        panel2 = new Panel();
        panel3 = new Panel();
        label1 = new Label();
        linkLabel1 = new LinkLabel();
        textBoxPassword = new TextBox();
        textBoxLogin = new TextBox();
        loginButton = new Button();
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
        panel2.TabIndex = 12;
        // 
        // panel3
        // 
        panel3.BackColor = Color.FromArgb(56, 55, 64);
        panel3.Controls.Add(label1);
        panel3.Controls.Add(linkLabel1);
        panel3.Controls.Add(textBoxPassword);
        panel3.Controls.Add(textBoxLogin);
        panel3.Controls.Add(loginButton);
        panel3.Dock = DockStyle.Fill;
        panel3.Location = new Point(0, 0);
        panel3.Name = "panel3";
        panel3.Size = new Size(612, 450);
        panel3.TabIndex = 13;
        panel3.Paint += panel3_Paint;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
        label1.ForeColor = Color.FromArgb(218, 220, 238);
        label1.Location = new Point(336, 97);
        label1.Name = "label1";
        label1.Size = new Size(120, 27);
        label1.TabIndex = 11;
        label1.Text = "вход";
        // 
        // linkLabel1
        // 
        linkLabel1.Anchor = AnchorStyles.Top;
        linkLabel1.AutoSize = true;
        linkLabel1.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        linkLabel1.ForeColor = Color.FromArgb(218, 220, 238);
        linkLabel1.LinkColor = Color.FromArgb(218, 220, 238);
        linkLabel1.Location = new Point(253, 342);
        linkLabel1.Name = "linkLabel1";
        linkLabel1.Size = new Size(295, 16);
        linkLabel1.TabIndex = 10;
        linkLabel1.TabStop = true;
        linkLabel1.Text = "зарегистрироваться";
        linkLabel1.LinkClicked += linkLabel1_LinkClicked;
        linkLabel1.Click += label1_Click;
        // 
        // textBox2
        // 
        textBoxPassword.Anchor = AnchorStyles.Top;
        textBoxPassword.BackColor = Color.FromArgb(78, 79, 90);
        textBoxPassword.BorderStyle = BorderStyle.None;
        textBoxPassword.Font = new Font("MS UI Gothic", 15.75F);
        textBoxPassword.ForeColor = Color.FromArgb(218, 220, 238);
        textBoxPassword.Location = new Point(236, 232);
        textBoxPassword.Name = "textBox2";
        textBoxPassword.Size = new Size(331, 21);
        textBoxPassword.TabIndex = 9;
        textBoxPassword.Text = "пароль";
        // 
        // textBox1
        // 
        textBoxLogin.Anchor = AnchorStyles.Top;
        textBoxLogin.BackColor = Color.FromArgb(78, 79, 90);
        textBoxLogin.BorderStyle = BorderStyle.None;
        textBoxLogin.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        textBoxLogin.ForeColor = Color.FromArgb(218, 220, 238);
        textBoxLogin.Location = new Point(236, 181);
        textBoxLogin.Name = "textBox1";
        textBoxLogin.Size = new Size(331, 21);
        textBoxLogin.TabIndex = 8;
        textBoxLogin.Text = "логин";
        // 
        // loginButton
        // 
        loginButton.Anchor = AnchorStyles.Top;
        loginButton.BackColor = Color.FromArgb(78, 79, 90);
        loginButton.FlatStyle = FlatStyle.Popup;
        loginButton.Font = new Font("MS UI Gothic", 15.75F);
        loginButton.ForeColor = Color.FromArgb(218, 220, 238);
        loginButton.Location = new Point(236, 293);
        loginButton.Name = "loginButton";
        loginButton.Size = new Size(331, 35);
        loginButton.TabIndex = 7;
        loginButton.Text = "продолжить";
        loginButton.UseVisualStyleBackColor = false;
        loginButton.Click += loginButton_Click;
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(76, 74, 86);
        panel1.Dock = DockStyle.Right;
        panel1.Location = new Point(612, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(188, 450);
        panel1.TabIndex = 11;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(61, 62, 71);
        ClientSize = new Size(800, 450);
        Controls.Add(panel2);
        Controls.Add(panel3);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Name = "Form1";
        Text = "Авторизация";
        Load += Form1_Load;
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Panel panel2;
    private Panel panel3;
    private Label label1;
    private LinkLabel linkLabel1;
    private TextBox textBoxPassword;
    private TextBox textBoxLogin;
    private Button loginButton;
    private Panel panel1;
}
