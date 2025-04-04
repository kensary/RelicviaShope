using RelicviaShope.Models;

namespace RelicviaShope.Forms;

public partial class ResetPasswordForm : Form
{
    public ResetPasswordForm()
    {
        InitializeComponent();
    }

    private void buttonContinue_Click(object sender, EventArgs e)
    {
        string passwordActiv = textBoxActivPassword.Text;
        string password = textBoxNewPassword.Text;
        string passwordConfirm = textBoxCopyPassword.Text;
        using DataBaseContext db = new DataBaseContext();
        var user = db.Users.FirstOrDefault(u => u.Id == User.ActiveUser!.Id);
        if (user!.Password != passwordActiv)
        {
            MessageBox.Show("Вы ввели не верный текущий пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        if (password != passwordConfirm)
        {
            MessageBox.Show("Ваши пароли не совполают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        if (user.Password == passwordActiv && password == passwordConfirm)
        {
            user.Password = password;
            db.SaveChanges();
            MessageBox.Show("Пароль успешно изменен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }

    private void ResetPasswordForm_Load(object sender, EventArgs e)
    {

    }
}
