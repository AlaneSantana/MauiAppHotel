namespace MauiAppHotel.Views;

public partial class ContratacaodaHospedagem : ContentPage
{
    App PropriedadesApp;



    //Construtor da página
    public ContratacaodaHospedagem()
    {
        InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

        dtpck_checkin.MinimumDate = DateTime.Now;
        dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);
        // date.value 
        dtpck_checkout.MinimumDate = dtpck_checkin.Date.Value.AddDays(1);
        dtpck_checkout.MaximumDate = dtpck_checkin.Date.Value.AddMonths(3);
    }

    // Evento do botão Avançar
    private async void BtnAvancar_Clicked(object sender, EventArgs e)
    {
     
        try
        {
             Navigation.PushAsync(new HospedagemContratada());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
        
    }

    // Evento do botão Sobre
    private async void BtnSobre_Clicked(object sender, EventArgs e)
    {
            Navigation.PushAsync(new Sobre());
    }

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_checkin = (DateTime)elemento.Date;

        dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
        dtpck_checkout.MaximumDate = data_selecionada_checkin.AddMonths(3);
    }
}