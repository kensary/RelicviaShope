﻿namespace RelicviaShope;

partial class ShopingCardForm
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
        button2 = new Button();
        button1 = new Button();
        panel2 = new Panel();
        listBoxTovars = new ListBox();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(64, 63, 73);
        panel1.Controls.Add(button2);
        panel1.Controls.Add(button1);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 340);
        panel1.Name = "panel1";
        panel1.Size = new Size(800, 110);
        panel1.TabIndex = 0;
        // 
        // button2
        // 
        button2.Anchor = AnchorStyles.Left;
        button2.BackColor = Color.FromArgb(78, 79, 90);
        button2.FlatStyle = FlatStyle.Flat;
        button2.Font = new Font("MS UI Gothic", 15.75F);
        button2.ForeColor = Color.FromArgb(218, 220, 238);
        button2.Location = new Point(33, 36);
        button2.Name = "button2";
        button2.Size = new Size(355, 50);
        button2.TabIndex = 1;
        button2.Text = "очистить корзину";
        button2.UseVisualStyleBackColor = false;
        button2.Click += button2_Click;
        // 
        // button1
        // 
        button1.Anchor = AnchorStyles.Right;
        button1.BackColor = Color.FromArgb(78, 79, 90);
        button1.FlatStyle = FlatStyle.Flat;
        button1.Font = new Font("MS UI Gothic", 15.75F);
        button1.ForeColor = Color.FromArgb(218, 220, 238);
        button1.Location = new Point(619, 36);
        button1.Name = "button1";
        button1.Size = new Size(149, 50);
        button1.TabIndex = 0;
        button1.Text = "купить";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // panel2
        // 
        panel2.BackColor = Color.FromArgb(78, 79, 90);
        panel2.Controls.Add(listBoxTovars);
        panel2.Dock = DockStyle.Fill;
        panel2.Location = new Point(0, 0);
        panel2.Name = "panel2";
        panel2.Size = new Size(800, 340);
        panel2.TabIndex = 1;
        // 
        // listBox1
        // 
        listBoxTovars.BackColor = Color.FromArgb(78, 79, 90);
        listBoxTovars.BorderStyle = BorderStyle.None;
        listBoxTovars.Dock = DockStyle.Fill;
        listBoxTovars.Font = new Font("MS UI Gothic", 15.75F);
        listBoxTovars.ForeColor = Color.FromArgb(218, 220, 238);
        listBoxTovars.FormattingEnabled = true;
        listBoxTovars.Location = new Point(0, 0);
        listBoxTovars.Name = "listBox1";
        listBoxTovars.Size = new Size(800, 340);
        listBoxTovars.TabIndex = 0;
        listBoxTovars.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        // 
        // ShopingCardForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(panel2);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.None;
        Name = "ShopingCardForm";
        Text = "ShopingCardForm";
        Load += ShopingCardForm_Load;
        panel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Button button2;
    private Button button1;
    private Panel panel2;
    private ListBox listBoxTovars;
}