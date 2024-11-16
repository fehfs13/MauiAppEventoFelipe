
using MauiAppEventoFelipe.Models;

namespace MauiAppEventoFelipe
{
    public partial class App : Application
    {
        public List<quarto> lista_quartos = new List<quarto>
        {
        new quarto()
        { Descricao = "Suite Super Luxo",
          ValorDiariaAdulto = 110.0,
          ValorDiariaCrianca = 55.0
                },
        new quarto()
        { Descricao = "Suite Luxo",
          ValorDiariaAdulto = 80.0,
          ValorDiariaCrianca = 40.0
                },
        new quarto()
        { Descricao = "Suite Single",
          ValorDiariaAdulto = 50.0,
          ValorDiariaCrianca = 25.0
                },
        new quarto()
        { Descricao = "Suite Crise",
          ValorDiariaAdulto = 25.0,
          ValorDiariaCrianca = 12.50
                }
    };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.contratacaodahospedagem());
        }
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 700;

            return window;
        }
    }
}
