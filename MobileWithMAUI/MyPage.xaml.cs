using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileWithMAUI;

public partial class MyPage : ContentPage
{
    public MyPage()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}
