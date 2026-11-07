namespace MauiAppHotel.Views;

public partial class ContratacaodaHospedagem : ContentPage
{
    public ContratacaodaHospedagem()
    {
        InitializeComponent();
    }

    private async void BtnSobre_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }
}