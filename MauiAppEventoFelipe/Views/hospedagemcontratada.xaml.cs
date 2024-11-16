namespace MauiAppEventoFelipe.Views
{
    public partial class hospedagemcontratada : ContentPage
    {
        public hospedagemcontratada()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PopAsync();

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");

            }





        }
    }
}