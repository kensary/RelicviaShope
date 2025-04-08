using RelicviaShope.Models;
using System.Security.Cryptography;
using System.Text;

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
            password = GetSHA256.CreateSHA256(textBox2.Text);

            User user = new User()
            {
                Name = login,
                Password = password
            };

            using DataBaseContext db = new DataBaseContext();

            if (db.Users.Any(u => u.Name == login))
            {
                MessageBox.Show("Пользователь с таким логином уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.Users.Add(user);
            db.SaveChanges();
            MessageBox.Show("Желаем удачи", "Регистрация завершена!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();

            return;
        }
        MessageBox.Show("Вы ввели разные пароли, повторите попытку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void panel3_Paint(object sender, PaintEventArgs e)
    {

    }

    private void Register_Load(object sender, EventArgs e)
    {

    }
}
