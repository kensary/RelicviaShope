namespace RelicviaShope;

partial class TovarForm
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
        labelName = new Label();
        label3 = new Label();
        richTextBoxDescription = new RichTextBox();
        button1 = new Button();
        textBoxPrice = new TextBox();
        label2 = new Label();
        labelTrader = new Label();
        SuspendLayout();
        // 
        // label1
        // 
        labelName.AutoSize = true;
        labelName.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        labelName.ForeColor = Color.FromArgb(218, 220, 238);
        labelName.Location = new Point(12, 30);
        labelName.Name = "label1";
        labelName.Size = new Size(178, 21);
        labelName.TabIndex = 0;
        labelName.Text = "название";
        labelName.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("MS UI Gothic", 15.75F);
        label3.ForeColor = Color.FromArgb(218, 220, 238);
        label3.Location = new Point(12, 437);
        label3.Name = "label3";
        label3.Size = new Size(94, 21);
        label3.TabIndex = 2;
        label3.Text = "цена";
        // 
        // richTextBox1
        // 
        richTextBoxDescription.BackColor = Color.FromArgb(78, 79, 90);
        richTextBoxDescription.BorderStyle = BorderStyle.None;
        richTextBoxDescription.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        richTextBoxDescription.ForeColor = Color.FromArgb(218, 220, 238);
        richTextBoxDescription.Location = new Point(12, 83);
        richTextBoxDescription.Name = "richTextBox1";
        richTextBoxDescription.ReadOnly = true;
        richTextBoxDescription.Size = new Size(433, 311);
        richTextBoxDescription.TabIndex = 3;
        richTextBoxDescription.Text = "описание";
        // 
        // button1
        // 
        button1.BackColor = Color.FromArgb(78, 79, 90);
        button1.Cursor = Cursors.Hand;
        button1.FlatStyle = FlatStyle.Flat;
        button1.Font = new Font("MS UI Gothic", 15.75F);
        button1.ForeColor = Color.FromArgb(218, 220, 238);
        button1.Location = new Point(12, 476);
        button1.Name = "button1";
        button1.Size = new Size(191, 28);
        button1.TabIndex = 4;
        button1.Text = "добавить в карзину";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // textBox1
        // 
        textBoxPrice.BackColor = Color.FromArgb(78, 79, 90);
        textBoxPrice.BorderStyle = BorderStyle.None;
        textBoxPrice.Font = new Font("MS UI Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        textBoxPrice.ForeColor = Color.FromArgb(218, 220, 238);
        textBoxPrice.Location = new Point(209, 476);
        textBoxPrice.Name = "textBox1";
        textBoxPrice.Size = new Size(102, 29);
        textBoxPrice.TabIndex = 5;
        textBoxPrice.Text = "1";
        textBoxPrice.TextChanged += textBox1_TextChanged;
        textBoxPrice.KeyPress += textBox1_KeyPress;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("MS UI Gothic", 15.75F);
        label2.ForeColor = Color.FromArgb(218, 220, 238);
        label2.Location = new Point(317, 480);
        label2.Name = "label2";
        label2.Size = new Size(56, 21);
        label2.TabIndex = 6;
        label2.Text = "шт.";
        // 
        // labelTrader
        // 
        labelTrader.AutoSize = true;
        labelTrader.Font = new Font("MS UI Gothic", 15.75F);
        labelTrader.ForeColor = Color.FromArgb(218, 220, 238);
        labelTrader.Location = new Point(12, 412);
        labelTrader.Name = "labelTrader";
        labelTrader.Size = new Size(182, 21);
        labelTrader.TabIndex = 7;
        labelTrader.Text = "продавец:";
        labelTrader.Click += labelTrader_Click;
        // 
        // TovarForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(56, 55, 64);
        ClientSize = new Size(457, 518);
        Controls.Add(labelTrader);
        Controls.Add(label2);
        Controls.Add(textBoxPrice);
        Controls.Add(button1);
        Controls.Add(richTextBoxDescription);
        Controls.Add(label3);
        Controls.Add(labelName);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "TovarForm";
        Text = "Товар";
        Load += Tovar_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelName;
    private Label label3;
    private RichTextBox richTextBoxDescription;
    private Button button1;
    private TextBox textBoxPrice;
    private Label label2;
    private Label labelTrader;
}