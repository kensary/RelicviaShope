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
        loginButton = new Button();
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        linkLabel1 = new LinkLabel();
        SuspendLayout();
        // 
        // loginButton
        // 
        loginButton.Location = new Point(340, 252);
        loginButton.Name = "loginButton";
        loginButton.Size = new Size(75, 23);
        loginButton.TabIndex = 0;
        loginButton.Text = "войти";
        loginButton.UseVisualStyleBackColor = true;
        loginButton.Click += loginButton_Click;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(213, 104);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(331, 23);
        textBox1.TabIndex = 1;
        textBox1.Text = "логин";
        // 
        // textBox2
        // 
        textBox2.Location = new Point(213, 179);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(331, 23);
        textBox2.TabIndex = 2;
        textBox2.Text = "пароль";
        // 
        // linkLabel1
        // 
        linkLabel1.AutoSize = true;
        linkLabel1.Location = new Point(324, 302);
        linkLabel1.Name = "linkLabel1";
        linkLabel1.Size = new Size(116, 15);
        linkLabel1.TabIndex = 3;
        linkLabel1.TabStop = true;
        linkLabel1.Text = "зарегестрироваться";
        linkLabel1.LinkClicked += linkLabel1_LinkClicked;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(linkLabel1);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(loginButton);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button loginButton;
    private TextBox textBox1;
    private TextBox textBox2;
    private LinkLabel linkLabel1;
}
