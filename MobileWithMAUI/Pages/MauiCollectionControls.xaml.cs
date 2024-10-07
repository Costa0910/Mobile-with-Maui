using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileWithMAUI.Models;

namespace MobileWithMAUI.Pages;

public partial class MauiCollectionControls : ContentPage
{
    public MauiCollectionControls()
    {
        InitializeComponent();
        BindingContext = new PhotoViewModel();
    }
}
