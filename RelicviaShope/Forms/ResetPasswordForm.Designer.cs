namespace RelicviaShope.Forms;

partial class ResetPasswordForm
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
        textBoxActivPassword = new TextBox();
        buttonContinue = new Button();
        label3 = new Label();
        textBoxNewPassword = new TextBox();
        textBoxCopyPassword = new TextBox();
        SuspendLayout();
        // 
        // textBoxActivPassword
        // 
        textBoxActivPassword.BackColor = Color.FromArgb(78, 79, 90);
        textBoxActivPassword.BorderStyle = BorderStyle.None;
        textBoxActivPassword.Font = new Font("MS UI Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        textBoxActivPassword.ForeColor = Color.FromArgb(218, 220, 238);
        textBoxActivPassword.Location = new Point(28, 129);
        textBoxActivPassword.Name = "textBoxActivPassword";
        textBoxActivPassword.Size = new Size(393, 29);
        textBoxActivPassword.TabIndex = 9;
        textBoxActivPassword.Text = "текущий пароль";
        textBoxActivPassword.TextAlign = HorizontalAlignment.Center;
        // 
        // buttonContinue
        // 
        buttonContinue.BackColor = Color.FromArgb(78, 79, 90);
        buttonContinue.Cursor = Cursors.Hand;
        buttonContinue.FlatStyle = FlatStyle.Flat;
        buttonContinue.Font = new Font("MS UI Gothic", 15.75F);
        buttonContinue.ForeColor = Color.FromArgb(218, 220, 238);
        buttonContinue.Location = new Point(117, 445);
        buttonContinue.Name = "buttonContinue";
        buttonContinue.Size = new Size(191, 28);
        buttonContinue.TabIndex = 8;
        buttonContinue.Text = "сменить";
        buttonContinue.UseVisualStyleBackColor = false;
        buttonContinue.Click += buttonContinue_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("MS UI Gothic", 15.75F);
        label3.ForeColor = Color.FromArgb(218, 220, 238);
        label3.Location = new Point(95, 53);
        label3.Name = "label3";
        label3.Size = new Size(247, 21);
        label3.TabIndex = 7;
        label3.Text = "смена пароля";
        // 
        // textBoxNewPassword
        // 
        textBoxNewPassword.BackColor = Color.FromArgb(78, 79, 90);
        textBoxNewPassword.BorderStyle = BorderStyle.None;
        textBoxNewPassword.Font = new Font("MS UI Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        textBoxNewPassword.ForeColor = Color.FromArgb(218, 220, 238);
        textBoxNewPassword.Location = new Point(28, 248);
        textBoxNewPassword.Name = "textBoxNewPassword";
        textBoxNewPassword.Size = new Size(393, 29);
        textBoxNewPassword.TabIndex = 10;
        textBoxNewPassword.Text = "новый пароль";
        textBoxNewPassword.TextAlign = HorizontalAlignment.Center;
        // 
        // textBoxCopyPassword
        // 
        textBoxCopyPassword.BackColor = Color.FromArgb(78, 79, 90);
        textBoxCopyPassword.BorderStyle = BorderStyle.None;
        textBoxCopyPassword.Font = new Font("MS UI Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        textBoxCopyPassword.ForeColor = Color.FromArgb(218, 220, 238);
        textBoxCopyPassword.Location = new Point(28, 357);
        textBoxCopyPassword.Name = "textBoxCopyPassword";
        textBoxCopyPassword.Size = new Size(393, 29);
        textBoxCopyPassword.TabIndex = 11;
        textBoxCopyPassword.Text = "повтор пароля";
        textBoxCopyPassword.TextAlign = HorizontalAlignment.Center;
        // 
        // ResetPasswordForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(56, 55, 64);
        ClientSize = new Size(449, 524);
        Controls.Add(textBoxCopyPassword);
        Controls.Add(textBoxNewPassword);
        Controls.Add(textBoxActivPassword);
        Controls.Add(buttonContinue);
        Controls.Add(label3);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "ResetPasswordForm";
        Text = "Смена пароля";
        Load += ResetPasswordForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox textBoxActivPassword;
    private Button buttonContinue;
    private Label label3;
    private TextBox textBoxNewPassword;
    private TextBox textBoxCopyPassword;
}