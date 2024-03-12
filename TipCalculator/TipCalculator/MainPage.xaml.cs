namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void slider_change(object sender, ValueChangedEventArgs e)
        {
            double value = (double)e.NewValue;

        }

        private void QuinzeBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void VinteBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void RoundDownBtn_Clicked(object sender, EventArgs e)
        {
            //Calcular a gorjeta, arredondo para baixo
           double result =  CalculeTip();
            double roundedResult = Math.Floor(result);
            double amout = Convert.ToDouble(Amount.Text.ToString());
            LabelTipValue.Text = roundedResult.ToString();
            LabelTotalValue.Text = LabelTotalValue.ToString();
        }

        private void RoundUpBtn_Clicked(object sender, EventArgs e)
        {
            double result = CalculeTip();
            double roundedResult = Math.Ceiling(result);
            double amout = Convert.ToDouble(Amount.Text.ToString());
            LabelTipValue.Text = roundedResult.ToString();
            LabelTotalValue.Text = LabelTotalValue.ToString();
        }

        private double CalculeTip()
        {
            //Preciso receber o valor do pedido digitado pelo usuário
            //Receber o valor de porcentagem para calcular a gorjeta
            //Realizar o calculo da gorjeta
            //Exibir o valor na Labal TotalTip
            
            double amount = Convert.ToDouble(Amount.Text.ToString());
            double percent = SliderTipPercent.Value;
           
            
            //Calculo da gorjeta
            double result = amount * (percent / 100);
            return result;

        }

    }



}
