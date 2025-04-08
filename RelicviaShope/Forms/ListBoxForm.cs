using RelicviaShope.Models;

namespace RelicviaShope;

public partial class ListBoxForm : Form
{
    public ListBoxForm()
    {
        InitializeComponent();
    }

    private void ListBoxForm_Load(object sender, EventArgs e)
    {
        using DataBaseContext db = new DataBaseContext();
        var tovars = db.Tovars.ToArray();
        listBox1.Items.Clear();
        listBox1.Items.AddRange(tovars);
    }

    private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
    {
        var selectedTovar = listBox1.SelectedItem as Tovar;

        if (selectedTovar != null)
        {
            Tovar.ActiveTovar = selectedTovar;
            TovarForm tovarForm = new TovarForm();
            tovarForm.ShowDialog();
        }
    }
}
