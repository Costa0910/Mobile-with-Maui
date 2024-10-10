using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileWithMAUI.MauiResources;

public partial class DividirContaApp : ContentPage
{
    decimal conta;
    int gorjeta;
    int numeroPessoas = 1;

    public DividirContaApp()
    {
        InitializeComponent();
    }

    private void TxtConta_OnCompleted(object? sender, EventArgs e)
    {
        conta = decimal.Parse(txtConta.Text);
        CalcularTotal();
    }

    private void CalcularTotal()
    {
        // Total gorjeta
        var totalGorjeta = (conta * gorjeta) / 100;
        var gorjetaPorPessoa = (totalGorjeta / numeroPessoas);
        blGorjetaPessoa.Text = $"{gorjetaPorPessoa:C}";
        // Subtotal
        var subtotal = (conta / numeroPessoas);
        blSubtotal.Text = $"{subtotal:C}";
        //Total
        var totalPorPessoa =
            (conta + totalGorjeta) / numeroPessoas;
        blTotal.Text = $"{totalPorPessoa:C}";
    }

    private void Button_OnClicked(object? sender, EventArgs e)
    {
        if (sender is Button)
        {
            var btn = (Button)sender;
            var percentage =
                int.Parse(btn.Text.Replace("%", ""));
            sldGorjeta.Value = percentage;
        }
    }

    private void sldGorjeta_OnValueChanged(object? sender,
        ValueChangedEventArgs e)
    {
        gorjeta = (int)sldGorjeta.Value;
        blGorjeta.Text = $"Gorjeta: {gorjeta}%";
        CalcularTotal();
    }

    private void BtnMenos_OnClicked(object? sender, EventArgs e)
    {
        if (numeroPessoas > 1)
        {
            numeroPessoas--;
            blNoPessoas.Text = numeroPessoas.ToString();
            CalcularTotal();
        }
    }

    private void BtnMais_OnClicked(object? sender, EventArgs e)
    {
        numeroPessoas++;
        blNoPessoas.Text = numeroPessoas.ToString();
        CalcularTotal();
    }

    private void BtnIniciar_OnClicked(object? sender, EventArgs e)
    {
        conta = 0.00m;
        gorjeta = 0;
        txtConta.Text = "";
        sldGorjeta.Value = 0;
        blNoPessoas.Text = "1";
        numeroPessoas = 1;
        CalcularTotal();
    }
}
