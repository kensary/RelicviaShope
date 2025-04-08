using RelicviaShope.Models;

namespace RelicviaShope;

public partial class TovarForm : Form
{
    public TovarForm()
    {
        InitializeComponent();
    }

    private void Tovar_Load(object sender, EventArgs e)
    {
        labelName.Text = Tovar.ActiveTovar!.Name;
        richTextBoxDescription.Text = Tovar.ActiveTovar.Description;
        label3.Text = Tovar.ActiveTovar.Price.ToString() + "$";
        using DataBaseContext db = new DataBaseContext();
        var trader = db.Users.FirstOrDefault(u => u.Id == Tovar.ActiveTovar.TraderId);
        labelTrader.Text = "продавец: " + trader!.Name;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (textBoxPrice.Text == "")
        {
            MessageBox.Show("Количество товара должно быть больше 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!int.TryParse(textBoxPrice.Text, out int value))
        {
            MessageBox.Show("Количество товара должно быть числом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (value <= 0)
        {
            MessageBox.Show("Количество товара должно быть больше 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        using DataBaseContext db = new DataBaseContext();

        if (db.ShopingCards.Any(u => u.TovarId == Tovar.ActiveTovar!.Id && u.UserId == User.ActiveUser!.Id))
        {
            ShopingCard shopingCard1 = db.ShopingCards.FirstOrDefault(u => u.TovarId == Tovar.ActiveTovar!.Id)!;
            shopingCard1.Quantity += value;
            db.SaveChanges();
            MessageBox.Show("Товар добавлен в корзину", "Ура!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

            return;
        }

        ShopingCard shopingCard = new ShopingCard()
        {
            TovarId = Tovar.ActiveTovar!.Id,
            UserId = User.ActiveUser!.Id,
            Quantity = value
        };

        db.Add(shopingCard);
        db.SaveChanges();
        MessageBox.Show("Товар добавлен в корзину", "Ура!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        this.Close();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
   (e.KeyChar != '.'))
        {
            e.Handled = true;
        }

        // only allow one decimal point
        if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
        {
            e.Handled = true;
        }
    }

    private void labelTrader_Click(object sender, EventArgs e)
    {

    }
}
