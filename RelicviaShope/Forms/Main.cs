using RelicviaShope.Forms;
using RelicviaShope.Models;

namespace RelicviaShope;

public partial class Main : Form
{
    private Form _activeForm = new Form();

    public Main()
    {
        InitializeComponent();
    }

    private void Main_Load(object sender, EventArgs e)
    {
        login.Text = User.ActiveUser!.Name;
        label1.Text = $"id: {User.ActiveUser!.Id.ToString()}";

        OpenChildForm(new ListBoxForm());

        using DataBaseContext db = new DataBaseContext();

        var user = db.Users.FirstOrDefault(u => u.Id == User.ActiveUser!.Id);

        if (user is Models.Trader)
        {
            button4.Visible = true;
            button4.Enabled = true;
        }
        if (user is Models.Admin)
        {
            button5.Visible = true;
            button5.Enabled = true;

            button6.Visible = true;
            button6.Enabled = true;
        }
    }


    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void button3_Click(object sender, EventArgs e)
    {
        OpenChildForm(new ShopingCardForm());

        label3.Text = "корзина";
    }
    public void OpenChildForm(Form childForm)
    {
        if (_activeForm != null)
        {
            _activeForm.Close();
        }

        _activeForm = childForm;

        childForm.TopLevel = false;
        childForm.FormBorderStyle = FormBorderStyle.None;
        childForm.Dock = DockStyle.Fill;

        panel3.Controls.Add(childForm);
        panel3.Tag = childForm;

        childForm.BringToFront();
        childForm.Show();

    }

    private void button2_Click(object sender, EventArgs e)
    {
        OpenChildForm(new ListBoxForm());
        label3.Text = "каталог";
    }

    private void button1_Click(object sender, EventArgs e)
    {
        OpenChildForm(new Profile());
        label3.Text = "профиль";
    }

    private void button5_Click(object sender, EventArgs e)
    {
        OpenChildForm(new RequestTraders());
    }

    private void button4_Click(object sender, EventArgs e)
    {
        OpenChildForm(new SellForm());
    }

    private void panel3_Paint(object sender, PaintEventArgs e)
    {

    }
}
