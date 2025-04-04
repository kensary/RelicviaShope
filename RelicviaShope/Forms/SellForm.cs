using RelicviaShope.Models;

namespace RelicviaShope.Forms;

public partial class SellForm : Form
{
    public SellForm()
    {
        InitializeComponent();
    }

    private void buttonSell_Click(object sender, EventArgs e)
    {
        string tradeName = textBoxNameTade.Text;
        string tradeDescription = richTextBoxDiscription.Text;
        string tradePrice = textBoxPrice.Text;
        using DataBaseContext db = new DataBaseContext();
        Tovar tovar = new Tovar()
        {
            Name = tradeName,
            Description = tradeDescription,
            Price = Convert.ToDecimal(tradePrice),
            TraderId = User.ActiveUser!.Id
        };
        db.Tovars.Add(tovar);
        db.SaveChanges();
        MessageBox.Show("Товар успешно добавлен в базу данных", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void SellForm_Load(object sender, EventArgs e)
    {

    }
}
