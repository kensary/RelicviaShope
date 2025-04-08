using RelicviaShope.Models;
using RelicviaShope.Providers;

namespace RelicviaShope;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        this.Hide();
        Register register = new Register();
        register.ShowDialog();
        this.Show();
    }

    private void loginButton_Click(object sender, EventArgs e)
    {
        string login = textBoxLogin.Text;
        string password = PasswordHash.CreateSHA256(textBoxPassword.Text);

        using DataBaseContext db = new DataBaseContext();

        var user = db.Users.FirstOrDefault(u => u.Name == login && u.Password == password);
        if (user == null)
        {
            MessageBox.Show(
            "Вы ввели не верный логин или пароль",
            "Ошибка", MessageBoxButtons.OK,
            MessageBoxIcon.Error);

            return;
        }
        User.ActiveUser = user;

        MessageBox.Show("Вы успешно вошли в систему", "Ура!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        Main main = new Main();
        this.Hide();
        main.ShowDialog();
        User.ActiveUser = null;
        this.Show();

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void panel3_Paint(object sender, PaintEventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
}
