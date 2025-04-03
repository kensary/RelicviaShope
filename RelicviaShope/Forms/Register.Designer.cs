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
        linkLabel1 = new LinkLabel();
        textBox2 = new TextBox();
        textBox1 = new TextBox();
        loginButton = new Button();
        textBox3 = new TextBox();
        SuspendLayout();
        // 
        // linkLabel1
        // 
        linkLabel1.AutoSize = true;
        linkLabel1.Location = new Point(381, 317);
        linkLabel1.Name = "linkLabel1";
        linkLabel1.Size = new Size(37, 15);
        linkLabel1.TabIndex = 7;
        linkLabel1.TabStop = true;
        linkLabel1.Text = "назад";
        linkLabel1.LinkClicked += linkLabel1_LinkClicked;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(235, 178);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(331, 23);
        textBox2.TabIndex = 6;
        textBox2.Text = "пароль";
        // 
        // textBox1
        // 
        textBox1.Location = new Point(235, 119);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(331, 23);
        textBox1.TabIndex = 5;
        textBox1.Text = "логин";
        // 
        // loginButton
        // 
        loginButton.Location = new Point(329, 291);
        loginButton.Name = "loginButton";
        loginButton.Size = new Size(139, 23);
        loginButton.TabIndex = 4;
        loginButton.Text = "зарегестрироваться";
        loginButton.UseVisualStyleBackColor = true;
        loginButton.Click += loginButton_Click;
        // 
        // textBox3
        // 
        textBox3.Location = new Point(235, 238);
        textBox3.Name = "textBox3";
        textBox3.Size = new Size(331, 23);
        textBox3.TabIndex = 8;
        textBox3.Text = "повтор пароля";
        // 
        // Register
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(textBox3);
        Controls.Add(linkLabel1);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(loginButton);
        Name = "Register";
        Text = "Register";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private LinkLabel linkLabel1;
    private TextBox textBox2;
    private TextBox textBox1;
    private Button loginButton;
    private TextBox textBox3;
}