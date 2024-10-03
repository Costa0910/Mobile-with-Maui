using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileWithMAUI.Pages;

public partial class MauiSetValuesControls : ContentPage
{
    public MauiSetValuesControls()
    {
        InitializeComponent();
    }

    private async void ChkBox_OnCheckedChanged(object? sender,
        CheckedChangedEventArgs e)
    {
        if (sender is null) return;
        var checkBox = (CheckBox)sender;
        if (checkBox.IsChecked)
            await DisplayAlert("Alert", "Checked", "OK");
        else
        {
            await DisplayAlert("Alert", "Unchecked", "OK");
        }
    }

    private void Slider_OnValueChanged(object? sender, ValueChangedEventArgs e)
    {
        if (sender is null) return;
        var slider = (Slider)sender;
        DisplaySlicerValue.Text = $"Slider value is: {slider.Value:F2}";
    }

    private void Stepper_OnValueChanged(object? sender, ValueChangedEventArgs e)
    {
        if (sender is null) return;
        var stepper = (Stepper)sender;
        DisplayStepperValue.Text = $"Stepper value is: {stepper.Value:F2}";
    }

    private void Switch_OnToggled(object? sender, ToggledEventArgs e)
    {
        if (sender is null) return;
        var switchControl = (Switch)sender;
        DisplaySwitchValue.Text = switchControl.IsToggled
            ? "Switch is ON"
            : "Switch is OFF";
    }

    private async void DatePicker_OnDateSelected(object? sender,
        DateChangedEventArgs e)
    {
        if (sender is null) return;
        var datePicker = (DatePicker)sender;
        var culture = System.Globalization.CultureInfo.CurrentCulture;
        await DisplayAlert("Alert",
            $"Date selected is: {datePicker.Date.ToString("d", culture)}",
            "OK");
    }

    private async void TimePicker_OnPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (sender is null) return;
        var timePicker = (TimePicker)sender;
        await DisplayAlert("Alert",
            $"Time selected is: {timePicker.Time.ToString()}",
            "OK");
    }
}
