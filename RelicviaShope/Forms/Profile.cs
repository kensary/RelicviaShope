using RelicviaShope.Forms;
using RelicviaShope.Models;

namespace RelicviaShope;

public partial class Profile : Form
{
    public Profile()
    {
        InitializeComponent();

        using DataBaseContext db = new DataBaseContext();
        var user = db.Users.FirstOrDefault(u => u.Id == User.ActiveUser!.Id);
        labelLogin.Text = "логин: " + user!.Name;
        labelId.Text = "ID: " + user.Id.ToString();

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

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }
}
