namespace TipTime
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            double valor = Math.Round(ValorConta.Value);
            double porcentagem = PorcentagemSlider;
            double gorjeta = ValorContaEntry * (porcentagem / 100);

        }

        private void Gorjeta_15Btn_Clicked(object sender, EventArgs e)
        {
            PorcentagemSlider.Value = 15;
        }

        private void Gorjeta_20Btn_Clicked(object sender, EventArgs e)
        {
            PorcentagemSlider.Value = 20;

        }

        private void Round_DownBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void Round_UpBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {

        }

        private void PorcentagemSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {

        }



    }
}
