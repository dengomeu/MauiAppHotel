namespace MauiAppHotel.Views;

public partial class Sobre : ContentPage
{
    public Sobre()
    {
        InitializeComponent();
    }

    private async void OnVoltarClicked(object sender, EventArgs e)
    {
        // Retorna para a tela principal
        await Navigation.PopAsync();
    }
}