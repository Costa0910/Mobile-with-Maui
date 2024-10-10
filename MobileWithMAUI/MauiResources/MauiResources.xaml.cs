using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MobileWithMAUI.MauiResources;

public partial class MauiResources : ContentPage
{
    public MauiResources()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await LoadMauiAsset();
    }

    async Task LoadMauiAsset()
    {
        await using var stream
            = await FileSystem.OpenAppPackageFileAsync("LoveDay.json");
        using var reader = new StreamReader(stream);

        var contents = await reader.ReadToEndAsync();

        var love = JsonSerializer.Deserialize<Love>(contents);
        BindingContext = love;
    }
}

public class Love
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
}
