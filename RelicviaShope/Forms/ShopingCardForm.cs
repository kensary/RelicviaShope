﻿using Microsoft.EntityFrameworkCore;
using RelicviaShope.Models;
using System.Data;

namespace RelicviaShope;

public partial class ShopingCardForm : Form
{
    public ShopingCardForm()
    {
        InitializeComponent();
    }

    private void ShopingCardForm_Load(object sender, EventArgs e)
    {
        DataBaseContext db = new DataBaseContext();
        var user = db.Users.Include(u => u.ShopingCards).ThenInclude(u => u.Tovar).FirstOrDefault(u => u.Id == User.ActiveUser!.Id);
        var shopingCards = user.ShopingCards.ToArray();
        var tovars = shopingCards.Select(u => u.Tovar).ToArray();
        listBoxTovars.Items.Clear();
        listBoxTovars.Items.AddRange(tovars);
        User.ActiveUser = user;
    }

    private void button2_Click(object sender, EventArgs e)
    {
        DataBaseContext db = new DataBaseContext();

        var user = db.Users.Include(u => u.ShopingCards).ThenInclude(u => u.Tovar).FirstOrDefault(u => u.Id == User.ActiveUser!.Id);
        var shopingCards = user.ShopingCards.ToArray();

        db.ShopingCards.RemoveRange(shopingCards);
        db.SaveChanges();
        listBoxTovars.Items.Clear();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        //TODO: реализовать покупку
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
