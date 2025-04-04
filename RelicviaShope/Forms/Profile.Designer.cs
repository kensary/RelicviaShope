namespace RelicviaShope;

partial class Profile
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
        buttonGetTrader = new Button();
        buttonResetPassword = new Button();
        labelStatus = new Label();
        labelId = new Label();
        labelLogin = new Label();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(64, 63, 73);
        panel1.Controls.Add(buttonGetTrader);
        panel1.Controls.Add(buttonResetPassword);
        panel1.Controls.Add(labelStatus);
        panel1.Controls.Add(labelId);
        panel1.Controls.Add(labelLogin);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(800, 450);
        panel1.TabIndex = 0;
        // 
        // buttonGetTrader
        // 
        buttonGetTrader.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        buttonGetTrader.BackColor = Color.FromArgb(78, 79, 90);
        buttonGetTrader.FlatStyle = FlatStyle.Flat;
        buttonGetTrader.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        buttonGetTrader.ForeColor = Color.FromArgb(218, 220, 238);
        buttonGetTrader.Location = new Point(520, 391);
        buttonGetTrader.Name = "buttonGetTrader";
        buttonGetTrader.RightToLeft = RightToLeft.No;
        buttonGetTrader.Size = new Size(250, 30);
        buttonGetTrader.TabIndex = 4;
        buttonGetTrader.Text = "стать продавцом";
        buttonGetTrader.UseVisualStyleBackColor = false;
        buttonGetTrader.Click += ButtonGetTrader_Click;
        // 
        // buttonResetPassword
        // 
        buttonResetPassword.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        buttonResetPassword.BackColor = Color.FromArgb(78, 79, 90);
        buttonResetPassword.FlatStyle = FlatStyle.Flat;
        buttonResetPassword.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        buttonResetPassword.ForeColor = Color.FromArgb(218, 220, 238);
        buttonResetPassword.Location = new Point(31, 391);
        buttonResetPassword.Name = "buttonResetPassword";
        buttonResetPassword.RightToLeft = RightToLeft.No;
        buttonResetPassword.Size = new Size(230, 30);
        buttonResetPassword.TabIndex = 3;
        buttonResetPassword.Text = "сменить пароль";
        buttonResetPassword.UseVisualStyleBackColor = false;
        buttonResetPassword.Click += ButtonResetBassword_Click;
        // 
        // labelStatus
        // 
        labelStatus.AutoSize = true;
        labelStatus.Font = new Font("MS UI Gothic", 15.75F);
        labelStatus.ForeColor = Color.FromArgb(218, 220, 238);
        labelStatus.Location = new Point(26, 144);
        labelStatus.Name = "labelStatus";
        labelStatus.Size = new Size(398, 21);
        labelStatus.TabIndex = 2;
        labelStatus.Text = "статус: пользователь";
        // 
        // labelId
        // 
        labelId.AutoSize = true;
        labelId.Font = new Font("MS UI Gothic", 15.75F);
        labelId.ForeColor = Color.FromArgb(218, 220, 238);
        labelId.Location = new Point(31, 67);
        labelId.Name = "labelId";
        labelId.Size = new Size(99, 21);
        labelId.TabIndex = 1;
        labelId.Text = "ID:000000";
        // 
        // labelLogin
        // 
        labelLogin.AutoSize = true;
        labelLogin.Font = new Font("MS UI Gothic", 15.75F);
        labelLogin.ForeColor = Color.FromArgb(218, 220, 238);
        labelLogin.Location = new Point(26, 27);
        labelLogin.Name = "labelLogin";
        labelLogin.Size = new Size(331, 21);
        labelLogin.TabIndex = 0;
        labelLogin.Text = "имя пользователя";
        // 
        // Profile
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ActiveCaptionText;
        ClientSize = new Size(800, 450);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.None;
        Name = "Profile";
        Text = "Profile";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Label labelLogin;
    private Label labelStatus;
    private Label labelId;
    private Button buttonGetTrader;
    private Button buttonResetPassword;
}