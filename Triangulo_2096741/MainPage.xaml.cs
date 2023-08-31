namespace Triangulo_2096741;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

        double A = Convert.ToDouble(a.Text);
        double B = Convert.ToDouble(b.Text);
        double C = Convert.ToDouble(c.Text);

        double Peri = (A + B + C) / 2;
        double area = Peri * ((Peri - A) * (Peri - B) * (Peri - C));
        double raiz = Math.Sqrt(area);
        string r = Convert.ToString(raiz);

        re.Text = "El resultado es : " + r;
    }
}

