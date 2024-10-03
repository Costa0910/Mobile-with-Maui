using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileWithMAUI.Pages;

public partial class MauiCommandControls : ContentPage
{
    public MauiCommandControls()
    {
        InitializeComponent();
    }

    private async void Button_OnClicked(object? sender, EventArgs e)
    {
        await TextToRotate.RotateTo(360, 2000);
        await DisplayAlert("Alert", "Button Clicked and text rotated", "OK");
    }

    private void BtnImgDemo_OnClickedClicked(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void RadioButton_OnCheckedChanged(object? sender,
        CheckedChangedEventArgs e)
    {
        var radio = (RadioButton)sender;
        if (radio is { IsChecked: true } && ShowSelectedPet.Text !=
            radio.Content)
        {
            ShowSelectedPet.Text = $"You selected {radio.Content}";
        }
    }

    private async void SearchBar_OnSearchButtonPressed(object? sender, EventArgs e)
    {  var searchBar = (SearchBar)sender;
        await DisplayAlert("Alert", $"You searched for {searchBar.Text}", "OK");
    }

    private void SwipeItem_OnInvoked(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }
}
