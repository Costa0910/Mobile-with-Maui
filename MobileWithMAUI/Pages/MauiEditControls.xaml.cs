using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileWithMAUI.Pages;

public partial class MauiEditControls : ContentPage
{
    public MauiEditControls()
    {
        InitializeComponent();
        BindingContext = this;
        IsBusy = false;

        ButtonLogin.Clicked += async (sender, args) =>
        {
            IsBusy = true;

            await Task.Delay(1000);
            if (Application.Current != null)
                Application.Current.MainPage = new NavigationPage(new MyPage());
        };
    }

    // private async void EntryName_OnTextChanged(object? sender, TextChangedEventArgs e)
    // {
    //     if (sender is null) return;
    //
    //     var oldText = e.OldTextValue;
    //     var newText = e.NewTextValue;
    //     var entry = EntryName.Text;
    //
    //     await DisplayAlert("Text Changed", $"Old Text: {oldText}\nNew Text: {newText}\nEntry Text: {entry}", "OK");
    // }
    //
    // private void EntryName_OnCompleted(object? sender, EventArgs e)
    // {
    //     if (sender is null) return;
    //
    //     var entry = EntryName.Text;
    //
    //     DisplayAlert("Text Completed", $"Entry Text: {entry}", "OK");
    // }
    //
    // private async void Button_OnClicked(object? sender, EventArgs e)
    // {
    //    await ProgressBar.ProgressTo(0.95, 2000, Easing.Linear);
    // }
}
