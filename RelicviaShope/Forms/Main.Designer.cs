namespace RelicviaShope;

partial class Main
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
        button6 = new Button();
        button5 = new Button();
        button4 = new Button();
        button3 = new Button();
        button2 = new Button();
        button1 = new Button();
        label1 = new Label();
        login = new Label();
        panel2 = new Panel();
        label3 = new Label();
        label2 = new Label();
        panel3 = new Panel();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(56, 55, 64);
        panel1.Controls.Add(button6);
        panel1.Controls.Add(button5);
        panel1.Controls.Add(button4);
        panel1.Controls.Add(button3);
        panel1.Controls.Add(button2);
        panel1.Controls.Add(button1);
        panel1.Controls.Add(label1);
        panel1.Controls.Add(login);
        panel1.Dock = DockStyle.Left;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(200, 450);
        panel1.TabIndex = 0;
        panel1.Paint += panel1_Paint;
        // 
        // button6
        // 
        button6.BackColor = Color.FromArgb(78, 79, 90);
        button6.Cursor = Cursors.Hand;
        button6.Enabled = false;
        button6.FlatStyle = FlatStyle.Flat;
        button6.Font = new Font("MS UI Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
        button6.ForeColor = Color.FromArgb(218, 220, 238);
        button6.Location = new Point(0, 394);
        button6.Name = "button6";
        button6.Size = new Size(200, 43);
        button6.TabIndex = 6;
        button6.Text = "пользователи";
        button6.UseVisualStyleBackColor = false;
        button6.Visible = false;
        // 
        // button5
        // 
        button5.BackColor = Color.FromArgb(78, 79, 90);
        button5.Cursor = Cursors.Hand;
        button5.Enabled = false;
        button5.FlatStyle = FlatStyle.Flat;
        button5.Font = new Font("MS UI Gothic", 15.75F);
        button5.ForeColor = Color.FromArgb(218, 220, 238);
        button5.Location = new Point(0, 331);
        button5.Name = "button5";
        button5.Size = new Size(200, 43);
        button5.TabIndex = 5;
        button5.Text = "заявки";
        button5.UseVisualStyleBackColor = false;
        button5.Visible = false;
        button5.Click += button5_Click;
        // 
        // button4
        // 
        button4.BackColor = Color.FromArgb(78, 79, 90);
        button4.Cursor = Cursors.Hand;
        button4.Enabled = false;
        button4.FlatStyle = FlatStyle.Flat;
        button4.Font = new Font("MS UI Gothic", 15.75F);
        button4.ForeColor = Color.FromArgb(218, 220, 238);
        button4.Location = new Point(0, 267);
        button4.Name = "button4";
        button4.Size = new Size(200, 43);
        button4.TabIndex = 4;
        button4.Text = "продать";
        button4.UseVisualStyleBackColor = false;
        button4.Visible = false;
        button4.Click += button4_Click;
        // 
        // button3
        // 
        button3.BackColor = Color.FromArgb(78, 79, 90);
        button3.Cursor = Cursors.Hand;
        button3.FlatStyle = FlatStyle.Flat;
        button3.Font = new Font("MS UI Gothic", 15.75F);
        button3.ForeColor = Color.FromArgb(218, 220, 238);
        button3.Location = new Point(0, 204);
        button3.Name = "button3";
        button3.Size = new Size(200, 43);
        button3.TabIndex = 3;
        button3.Text = "карзина";
        button3.UseVisualStyleBackColor = false;
        button3.Click += button3_Click;
        // 
        // button2
        // 
        button2.BackColor = Color.FromArgb(78, 79, 90);
        button2.Cursor = Cursors.Hand;
        button2.FlatStyle = FlatStyle.Flat;
        button2.Font = new Font("MS UI Gothic", 15.75F);
        button2.ForeColor = Color.FromArgb(218, 220, 238);
        button2.Location = new Point(0, 141);
        button2.Name = "button2";
        button2.Size = new Size(200, 43);
        button2.TabIndex = 2;
        button2.Text = "каталог";
        button2.UseVisualStyleBackColor = false;
        button2.Click += button2_Click;
        // 
        // button1
        // 
        button1.BackColor = Color.FromArgb(78, 79, 90);
        button1.Cursor = Cursors.Hand;
        button1.FlatStyle = FlatStyle.Flat;
        button1.Font = new Font("MS UI Gothic", 15.75F);
        button1.ForeColor = Color.FromArgb(218, 220, 238);
        button1.Location = new Point(0, 79);
        button1.Name = "button1";
        button1.Size = new Size(200, 43);
        button1.TabIndex = 0;
        button1.Text = "профиль";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("MS UI Gothic", 15.75F);
        label1.ForeColor = Color.FromArgb(218, 220, 238);
        label1.Location = new Point(12, 40);
        label1.Name = "label1";
        label1.Size = new Size(94, 21);
        label1.TabIndex = 1;
        label1.Text = "id:000000";
        // 
        // login
        // 
        login.AutoSize = true;
        login.Font = new Font("MS UI Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
        login.ForeColor = Color.FromArgb(218, 220, 238);
        login.Location = new Point(12, 9);
        login.Name = "login";
        login.Size = new Size(189, 12);
        login.TabIndex = 0;
        login.Text = "имя пользователя";
        // 
        // panel2
        // 
        panel2.BackColor = Color.FromArgb(64, 63, 73);
        panel2.Controls.Add(label3);
        panel2.Controls.Add(label2);
        panel2.Dock = DockStyle.Top;
        panel2.Location = new Point(200, 0);
        panel2.Name = "panel2";
        panel2.Size = new Size(600, 76);
        panel2.TabIndex = 1;
        // 
        // label3
        // 
        label3.Anchor = AnchorStyles.Bottom;
        label3.AutoSize = true;
        label3.Font = new Font("MS UI Gothic", 15.75F);
        label3.ForeColor = Color.FromArgb(218, 220, 238);
        label3.Location = new Point(231, 47);
        label3.Name = "label3";
        label3.Size = new Size(157, 21);
        label3.TabIndex = 3;
        label3.Text = "каталог";
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.Top;
        label2.AutoSize = true;
        label2.Font = new Font("Old English Text MT", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label2.ForeColor = Color.FromArgb(218, 220, 238);
        label2.Location = new Point(188, 0);
        label2.Name = "label2";
        label2.Size = new Size(239, 44);
        label2.TabIndex = 0;
        label2.Text = "RelicviaShope";
        // 
        // panel3
        // 
        panel3.BackColor = Color.FromArgb(78, 79, 90);
        panel3.Dock = DockStyle.Fill;
        panel3.Location = new Point(200, 76);
        panel3.Name = "panel3";
        panel3.Size = new Size(600, 374);
        panel3.TabIndex = 2;
        // 
        // Main
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(78, 79, 90);
        ClientSize = new Size(800, 450);
        Controls.Add(panel3);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Name = "Main";
        Text = "Relicvia Shope";
        Load += Main_Load;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Panel panel2;
    private Button button2;
    private Button button1;
    private Label label1;
    private Label login;
    private Label label2;
    private Panel panel3;
    private Label label3;
    private Button button3;
    private Button button6;
    private Button button5;
    private Button button4;
}