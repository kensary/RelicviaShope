using RelicviaShope.Models;

namespace RelicviaShope.Forms;

public partial class AddTraderForm : Form
{
    public AddTraderForm()
    {
        InitializeComponent();
    }

    private void AddTraderForm_Load(object sender, EventArgs e)
    {
        using DataBaseContext db = new DataBaseContext();
        var requestTTraders = db.HelpTraders.FirstOrDefault(u => u.Id == HelpTraders.ActiveHelpTrader!.Id);
        labelUser.Text = requestTTraders!.UserName;
        labelUserID.Text = "ID пользователя: " + requestTTraders.UserId.ToString();
        labelUserINN.Text = "ИНН: " + requestTTraders.INN;
    }

    private void buttonConfirm_Click(object sender, EventArgs e)
    {
        using DataBaseContext db = new DataBaseContext();
        var requestTTraders = db.HelpTraders.FirstOrDefault(u => u.Id == HelpTraders.ActiveHelpTrader!.Id);
        var user = db.Users.FirstOrDefault(u => u.Id == requestTTraders!.UserId);
        db.Users.Remove(user);
        Trader trader = new Trader()
        {
            Id = user!.Id,
            Name = user.Name,
            Inn = requestTTraders!.INN,
            Password = user!.Password,
        };
        db.Traders.Add(trader);
        db.HelpTraders.Remove(requestTTraders);
        db.SaveChanges();
        MessageBox.Show("Пользователь успешно добавлен в базу данных как продавец", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        using DataBaseContext db = new DataBaseContext();
        var requestTTraders = db.HelpTraders.FirstOrDefault(u => u.Id == HelpTraders.ActiveHelpTrader!.Id);
        db.HelpTraders.Remove(requestTTraders!);
        db.SaveChanges();
        MessageBox.Show("Заявка на получение статуса продавца отклонена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        Close();
    }
}
