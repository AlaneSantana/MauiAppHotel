using MauiAppHotel.Models;

namespace MauiAppHotel;

    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suíte Super Luxo",
                ValorDiariaAdultos = 500.0,
                ValorDiariaCriancas = 250.0
            },
        new Quarto()
    {
        Descricao = "Suíte Master",
                ValorDiariaAdultos = 300.0,
                ValorDiariaCriancas = 150.0

            },
        new Quarto()
    {
        Descricao = "Suíte Single",
                ValorDiariaAdultos = 150.0,
                ValorDiariaCriancas = 50.0
            },
        new Quarto()
    {
        Descricao = "Suíte Crise",
                ValorDiariaAdultos = 50.0,
                ValorDiariaCriancas = 25.0
            },

        };

    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new Views.ContratacaodaHospedagem());
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        var window = base.CreateWindow(activationState);

        window.Width = 400;
        window.Height = 600;

        return window;
    }
}