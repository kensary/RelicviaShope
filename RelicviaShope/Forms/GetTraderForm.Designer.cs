namespace RelicviaShope.Forms;

partial class GetTraderForm
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
        textBoxINN = new TextBox();
        label3 = new Label();
        buttonConfirm = new Button();
        SuspendLayout();
        // 
        // textBoxINN
        // 
        textBoxINN.BackColor = Color.FromArgb(78, 79, 90);
        textBoxINN.BorderStyle = BorderStyle.None;
        textBoxINN.Font = new Font("MS UI Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        textBoxINN.ForeColor = Color.FromArgb(218, 220, 238);
        textBoxINN.Location = new Point(27, 88);
        textBoxINN.Name = "textBoxINN";
        textBoxINN.Size = new Size(393, 29);
        textBoxINN.TabIndex = 14;
        textBoxINN.Text = "введите ваш ИНН";
        textBoxINN.TextAlign = HorizontalAlignment.Center;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("MS UI Gothic", 15.75F);
        label3.ForeColor = Color.FromArgb(218, 220, 238);
        label3.Location = new Point(68, 26);
        label3.Name = "label3";
        label3.Size = new Size(310, 21);
        label3.TabIndex = 12;
        label3.Text = "стать продавцом";
        // 
        // buttonConfirm
        // 
        buttonConfirm.BackColor = Color.FromArgb(78, 79, 90);
        buttonConfirm.Cursor = Cursors.Hand;
        buttonConfirm.FlatStyle = FlatStyle.Flat;
        buttonConfirm.Font = new Font("MS UI Gothic", 15.75F);
        buttonConfirm.ForeColor = Color.FromArgb(218, 220, 238);
        buttonConfirm.Location = new Point(27, 161);
        buttonConfirm.Name = "buttonConfirm";
        buttonConfirm.Size = new Size(393, 28);
        buttonConfirm.TabIndex = 13;
        buttonConfirm.Text = "отправить заявку";
        buttonConfirm.UseVisualStyleBackColor = false;
        buttonConfirm.Click += buttonConfirm_Click;
        // 
        // GetTraderForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(56, 55, 64);
        ClientSize = new Size(445, 223);
        Controls.Add(textBoxINN);
        Controls.Add(buttonConfirm);
        Controls.Add(label3);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "GetTraderForm";
        Text = "GetTraderForm";
        Load += GetTraderForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private TextBox textBoxINN;
    private Label label3;
    private Button buttonConfirm;
}