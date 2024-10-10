using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileWithMAUI.Models;

namespace MobileWithMAUI.MauiBindingDemo;

public partial class NotifyBinding : ContentPage
{
    public Product Product { get; set; }

    public NotifyBinding()
    {
        InitializeComponent();
        Product = new Product
        {
            Name = "Product 1",
            Stock = 23,
            Price = 100
        };

        BindingContext = Product;
    }

    private async void BtnAtualiza_OnClicked(object? sender, EventArgs e)
    {
        Product.Name = "Product 2";
        Product.Stock = 10;
        Product.Price = 200;
        await DisplayAlert("Produto Atualizado",
            "Produto Atualizado com sucesso", "OK");
    }
}
