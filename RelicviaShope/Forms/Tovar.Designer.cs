﻿namespace RelicviaShope;

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
        label1 = new Label();
        label3 = new Label();
        richTextBox1 = new RichTextBox();
        button1 = new Button();
        textBox1 = new TextBox();
        label2 = new Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        label1.ForeColor = Color.FromArgb(218, 220, 238);
        label1.Location = new Point(12, 31);
        label1.Name = "label1";
        label1.Size = new Size(178, 21);
        label1.TabIndex = 0;
        label1.Text = "название";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("MS UI Gothic", 15.75F);
        label3.ForeColor = Color.FromArgb(218, 220, 238);
        label3.Location = new Point(12, 428);
        label3.Name = "label3";
        label3.Size = new Size(94, 21);
        label3.TabIndex = 2;
        label3.Text = "цена";
        // 
        // richTextBox1
        // 
        richTextBox1.BackColor = Color.FromArgb(78, 79, 90);
        richTextBox1.BorderStyle = BorderStyle.None;
        richTextBox1.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        richTextBox1.ForeColor = Color.FromArgb(218, 220, 238);
        richTextBox1.Location = new Point(12, 83);
        richTextBox1.Name = "richTextBox1";
        richTextBox1.ReadOnly = true;
        richTextBox1.Size = new Size(433, 311);
        richTextBox1.TabIndex = 3;
        richTextBox1.Text = "описание";
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
        textBox1.BackColor = Color.FromArgb(78, 79, 90);
        textBox1.BorderStyle = BorderStyle.None;
        textBox1.Font = new Font("MS UI Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        textBox1.ForeColor = Color.FromArgb(218, 220, 238);
        textBox1.Location = new Point(209, 476);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(102, 29);
        textBox1.TabIndex = 5;
        textBox1.Text = "0";
        textBox1.TextChanged += textBox1_TextChanged;
        textBox1.KeyPress += textBox1_KeyPress;
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
        // TovarForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(56, 55, 64);
        ClientSize = new Size(457, 518);
        Controls.Add(label2);
        Controls.Add(textBox1);
        Controls.Add(button1);
        Controls.Add(richTextBox1);
        Controls.Add(label3);
        Controls.Add(label1);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "TovarForm";
        Text = "Товар";
        Load += Tovar_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label3;
    private RichTextBox richTextBox1;
    private Button button1;
    private TextBox textBox1;
    private Label label2;
}