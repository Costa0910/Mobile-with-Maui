using MobileWithMAUI.Models;

namespace MobileWithMAUI;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        var product = new Product
        {
            Name = "Product 1",
            Price = 100.00m,
            Stock = 10
        };

        var productBiding = new Binding(nameof(Models.Product.Name), source:
            product, stringFormat: "Product: {0}");
        var priceBinding = new Binding(nameof(Models.Product.Price), source: product,
            stringFormat: "Price: {0:C}");
        var stockBinding = new Binding(nameof(Models.Product.Stock), source: product,
            stringFormat: "Stock: {0}");

        LabelBinding.SetBinding(Label.TextProperty, productBiding);
        LabelPrice.SetBinding(Label.TextProperty, priceBinding);
        LabelStock.SetBinding(Label.TextProperty, stockBinding);
    }
}
