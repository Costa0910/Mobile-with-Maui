using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MobileWithMAUI.Models;

public class Product : INotifyPropertyChanged
{
    private int _stock;
    private string _name;
    private decimal _price;

    public string Name
    {
        get => _name;
        set
        {
            _name = value;
            OnPropertyChanged();
        }
    }

    public decimal Price
    {
        get => _price;
        set
        {
            _price = value;
            OnPropertyChanged();
        }
    }

    public int Stock
    {
        get => _stock;
        set
        {
            _stock = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged(
        [CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this,
            new PropertyChangedEventArgs(propertyName));
    }
}
