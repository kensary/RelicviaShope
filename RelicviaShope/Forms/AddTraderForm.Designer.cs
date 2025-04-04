namespace RelicviaShope.Forms
{
    partial class AddTraderForm
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
            labelUser = new Label();
            labelUserID = new Label();
            labelUserINN = new Label();
            buttonConfirm = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("MS UI Gothic", 15.75F);
            labelUser.ForeColor = Color.FromArgb(218, 220, 238);
            labelUser.Location = new Point(25, 26);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(262, 21);
            labelUser.TabIndex = 13;
            labelUser.Text = "пользователь";
            // 
            // labelUserID
            // 
            labelUserID.AutoSize = true;
            labelUserID.Font = new Font("MS UI Gothic", 15.75F);
            labelUserID.ForeColor = Color.FromArgb(218, 220, 238);
            labelUserID.Location = new Point(25, 74);
            labelUserID.Name = "labelUserID";
            labelUserID.Size = new Size(83, 21);
            labelUserID.TabIndex = 14;
            labelUserID.Text = "id:00000";
            // 
            // labelUserINN
            // 
            labelUserINN.AutoSize = true;
            labelUserINN.Font = new Font("MS UI Gothic", 15.75F);
            labelUserINN.ForeColor = Color.FromArgb(218, 220, 238);
            labelUserINN.Location = new Point(25, 117);
            labelUserINN.Name = "labelUserINN";
            labelUserINN.Size = new Size(239, 21);
            labelUserINN.TabIndex = 15;
            labelUserINN.Text = "ИНН: XXXXXXXXXXXX";
            // 
            // buttonConfirm
            // 
            buttonConfirm.BackColor = Color.FromArgb(78, 79, 90);
            buttonConfirm.Cursor = Cursors.Hand;
            buttonConfirm.FlatStyle = FlatStyle.Flat;
            buttonConfirm.Font = new Font("MS UI Gothic", 15.75F);
            buttonConfirm.ForeColor = Color.FromArgb(218, 220, 238);
            buttonConfirm.Location = new Point(25, 322);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(326, 28);
            buttonConfirm.TabIndex = 16;
            buttonConfirm.Text = "одобрить";
            buttonConfirm.UseVisualStyleBackColor = false;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(78, 79, 90);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("MS UI Gothic", 15.75F);
            button1.ForeColor = Color.FromArgb(218, 220, 238);
            button1.Location = new Point(25, 390);
            button1.Name = "button1";
            button1.Size = new Size(326, 28);
            button1.TabIndex = 17;
            button1.Text = "отклонить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AddTraderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(56, 55, 64);
            ClientSize = new Size(375, 453);
            Controls.Add(button1);
            Controls.Add(buttonConfirm);
            Controls.Add(labelUserINN);
            Controls.Add(labelUserID);
            Controls.Add(labelUser);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddTraderForm";
            Text = "AddTraderForm";
            Load += AddTraderForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUser;
        private Label labelUserID;
        private Label labelUserINN;
        private Button buttonConfirm;
        private Button button1;
    }
}