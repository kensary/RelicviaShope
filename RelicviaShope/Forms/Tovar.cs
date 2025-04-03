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
        label1.Text = Tovar.ActiveTovar!.Name;
        richTextBox1.Text = Tovar.ActiveTovar.Description;
        label3.Text = Tovar.ActiveTovar.Price.ToString() + "$";
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (textBox1.Text == "")
        {
            MessageBox.Show("Количество товара должно быть больше 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        else
        {
            int value = int.Parse(textBox1.Text);
            if (value <= 0)
            {
                MessageBox.Show("Количество товара должно быть больше 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                using DataBaseContext db = new DataBaseContext();
                if (db.ShopingCards.Any(u=>u.TovarId == Tovar.ActiveTovar!.Id && u.UserId == User.ActiveUser!.Id))
                {
                    ShopingCard shopingCard1 = db.ShopingCards.FirstOrDefault(u => u.TovarId == Tovar.ActiveTovar!.Id)!;
                    shopingCard1.Quantity += value;
                    db.SaveChanges();
                    MessageBox.Show("Товар добавлен в корзину", "Ура!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    ShopingCard shopingCard = new ShopingCard()
                    {
                        TovarId = Tovar.ActiveTovar.Id,
                        UserId = User.ActiveUser!.Id,
                        Quantity = value
                    };
                    db.Add(shopingCard);
                    db.SaveChanges();
                    MessageBox.Show("Товар добавлен в корзину", "Ура!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
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
}
