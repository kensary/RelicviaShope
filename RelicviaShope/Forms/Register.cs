using RelicviaShope.Models;

namespace RelicviaShope;

public partial class Register : Form
{
    public Register()
    {
        InitializeComponent();
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Close();
    }

    private void loginButton_Click(object sender, EventArgs e)
    {
        string login = textBox1.Text;
        string password = "";        
        if (textBox2.Text == textBox3.Text)
        {
            password = textBox2.Text;
            User user = new User()
            {
                Name = login,
                Password = password 
            };
            using DataBaseContext db = new DataBaseContext();
            if (db.Users.Any(u => u.Name == login))
            {
                MessageBox.Show("Пользователь с таким логином уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                db.Users.Add(user);
                db.SaveChanges();
                MessageBox.Show("Желаем удачи", "Регистрация завершена!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
        else
        {
            MessageBox.Show("Вы ввели разные пароли, повторите попытку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
