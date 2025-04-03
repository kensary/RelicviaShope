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
        label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
        label1.Location = new Point(12, 19);
        label1.Name = "label1";
        label1.Size = new Size(126, 32);
        label1.TabIndex = 0;
        label1.Text = "название";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
        label3.Location = new Point(12, 406);
        label3.Name = "label3";
        label3.Size = new Size(44, 20);
        label3.TabIndex = 2;
        label3.Text = "цена";
        // 
        // richTextBox1
        // 
        richTextBox1.Enabled = false;
        richTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        richTextBox1.Location = new Point(12, 69);
        richTextBox1.Name = "richTextBox1";
        richTextBox1.Size = new Size(423, 311);
        richTextBox1.TabIndex = 3;
        richTextBox1.Text = "описание";
        // 
        // button1
        // 
        button1.Location = new Point(12, 483);
        button1.Name = "button1";
        button1.Size = new Size(154, 23);
        button1.TabIndex = 4;
        button1.Text = "добавить в карзину";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(190, 483);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(63, 23);
        textBox1.TabIndex = 5;
        textBox1.Text = "0";
        textBox1.TextChanged += textBox1_TextChanged;
        textBox1.KeyPress += textBox1_KeyPress;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(259, 487);
        label2.Name = "label2";
        label2.Size = new Size(26, 15);
        label2.TabIndex = 6;
        label2.Text = "шт.";
        // 
        // TovarForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(457, 518);
        Controls.Add(label2);
        Controls.Add(textBox1);
        Controls.Add(button1);
        Controls.Add(richTextBox1);
        Controls.Add(label3);
        Controls.Add(label1);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "TovarForm";
        Text = "Tovar";
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