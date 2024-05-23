namespace FormulaSuCarnet;

public partial class Suma : ContentPage
{
	public Suma()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(entry1.Text)&& !string.IsNullOrEmpty(entry2.Text))
        {
            double resultado, datoa, datob;
            datoa = Convert.ToDouble(entry1.Text);
            datob = Convert.ToDouble(entry2.Text);
            resultado = datoa + datob;
            entryr.Text = resultado.ToString();
        }
        else
        {
            DisplayAlert("Error", "Introduce todos los numeros", "ok");
        }
    }
}