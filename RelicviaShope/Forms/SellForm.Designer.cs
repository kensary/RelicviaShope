namespace RelicviaShope.Forms;

partial class SellForm
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
        buttonSell = new Button();
        textBoxNameTade = new TextBox();
        textBoxPrice = new TextBox();
        richTextBoxDiscription = new RichTextBox();
        SuspendLayout();
        // 
        // buttonSell
        // 
        buttonSell.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        buttonSell.BackColor = Color.FromArgb(78, 79, 90);
        buttonSell.FlatStyle = FlatStyle.Flat;
        buttonSell.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        buttonSell.ForeColor = Color.FromArgb(218, 220, 238);
        buttonSell.Location = new Point(32, 393);
        buttonSell.Name = "buttonSell";
        buttonSell.RightToLeft = RightToLeft.No;
        buttonSell.Size = new Size(162, 30);
        buttonSell.TabIndex = 9;
        buttonSell.Text = "продать";
        buttonSell.UseVisualStyleBackColor = false;
        buttonSell.Click += buttonSell_Click;
        // 
        // textBoxNameTade
        // 
        textBoxNameTade.Anchor = AnchorStyles.Left;
        textBoxNameTade.BackColor = Color.FromArgb(78, 79, 90);
        textBoxNameTade.BorderStyle = BorderStyle.None;
        textBoxNameTade.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        textBoxNameTade.ForeColor = Color.FromArgb(218, 220, 238);
        textBoxNameTade.Location = new Point(31, 39);
        textBoxNameTade.Name = "textBoxNameTade";
        textBoxNameTade.Size = new Size(747, 21);
        textBoxNameTade.TabIndex = 10;
        textBoxNameTade.Text = "Название товара";
        // 
        // textBoxPrice
        // 
        textBoxPrice.Anchor = AnchorStyles.Left;
        textBoxPrice.BackColor = Color.FromArgb(78, 79, 90);
        textBoxPrice.BorderStyle = BorderStyle.None;
        textBoxPrice.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        textBoxPrice.ForeColor = Color.FromArgb(218, 220, 238);
        textBoxPrice.Location = new Point(31, 336);
        textBoxPrice.Name = "textBoxPrice";
        textBoxPrice.Size = new Size(747, 21);
        textBoxPrice.TabIndex = 11;
        textBoxPrice.Text = "цена товара ($)";
        // 
        // richTextBoxDiscription
        // 
        richTextBoxDiscription.Anchor = AnchorStyles.Left;
        richTextBoxDiscription.BackColor = Color.FromArgb(78, 79, 90);
        richTextBoxDiscription.BorderStyle = BorderStyle.None;
        richTextBoxDiscription.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        richTextBoxDiscription.ForeColor = Color.FromArgb(218, 220, 238);
        richTextBoxDiscription.Location = new Point(31, 83);
        richTextBoxDiscription.Name = "richTextBoxDiscription";
        richTextBoxDiscription.Size = new Size(747, 233);
        richTextBoxDiscription.TabIndex = 12;
        richTextBoxDiscription.Text = "описание товара";
        // 
        // SellForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(56, 55, 64);
        ClientSize = new Size(801, 450);
        Controls.Add(richTextBoxDiscription);
        Controls.Add(textBoxPrice);
        Controls.Add(textBoxNameTade);
        Controls.Add(buttonSell);
        Name = "SellForm";
        Text = "SellForm";
        Load += SellForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button buttonSell;
    private TextBox textBoxNameTade;
    private TextBox textBoxPrice;
    private RichTextBox richTextBoxDiscription;
}