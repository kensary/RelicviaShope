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

namespace RelicviaShope.Forms
{
    public partial class GetTraderForm : Form
    {
        public GetTraderForm()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string inn = textBoxINN.Text;
            if (inn.Length != 12)
            {
                MessageBox.Show("Неверный формат ИНН", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using DataBaseContext db = new DataBaseContext();
                if (db.HelpTraders.Any(u=>u.UserId == User.ActiveUser!.Id))
                {
                    MessageBox.Show("Вы уже отправили заявку на получение статуса продавца", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var user = db.Users.FirstOrDefault(u => u.Id == User.ActiveUser!.Id);
                    HelpTraders helpTraders = new HelpTraders()
                    {
                        INN = inn,
                        UserId = user!.Id,
                        UserName = user.Name,
                    };
                    db.HelpTraders.Add(helpTraders);
                    db.SaveChanges();
                    MessageBox.Show("Заявка на получение статуса продавца отправлена, ожидайте подтверждения модерации", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
