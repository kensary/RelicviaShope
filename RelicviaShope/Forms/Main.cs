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
        label1.Text = User.ActiveUser!.Id.ToString();
        OpenChildForm(new ListBoxForm());
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
}
