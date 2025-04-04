﻿using RelicviaShope.Forms;
using RelicviaShope.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RelicviaShope
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
            using DataBaseContext db = new DataBaseContext();
            var user = db.Users.FirstOrDefault(u => u.Id == User.ActiveUser!.Id);
            labelLogin.Text = user!.Name;
            labelId.Text = user.Id.ToString();
            if (user is Models.User)
            {
                labelStatus.Text = $"статус: пользователь";
            }
            if (user is Models.Trader)
            {
                labelStatus.Text = $"статус: продавец";
            }
            if (user is Models.Admin)
            {
                labelStatus.Text = $"статус: администратор";
            }
        }
        private void ButtonResetBassword_Click(object sender, EventArgs e)
        {
            ResetPasswordForm resetPasswordForm = new ResetPasswordForm();
            resetPasswordForm.ShowDialog();
        }
        private void ButtonGetTrader_Click(object sender, EventArgs e)
        {
            GetTraderForm getTraderForm = new GetTraderForm();
            getTraderForm.ShowDialog();
        }
    }
}
