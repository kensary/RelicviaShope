using RelicviaShope.Models;

namespace RelicviaShope.Forms;

public partial class RequestTraders : Form
{
    public RequestTraders()
    {
        InitializeComponent();
    }

    private void RequestTraders_Load(object sender, EventArgs e)
    {
        using DataBaseContext db = new DataBaseContext();
        var requestTraders = db.HelpTraders.ToArray();
        listBoxRequest.Items.Clear();
        listBoxRequest.Items.AddRange(requestTraders);
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        var selectedRewuestTraders = listBoxRequest.SelectedItem as HelpTraders;
        if (selectedRewuestTraders != null)
        {
            HelpTraders.ActiveHelpTrader = selectedRewuestTraders;
            AddTraderForm addTraderForm = new AddTraderForm();
            addTraderForm.ShowDialog();
        }
    }
}
