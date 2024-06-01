namespace Complementario05;

public partial class BaseRectangulo : ContentPage
{
	public BaseRectangulo()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        // Luego agregamos un double con tryparse para verificar si se han ingresado valores válidos para altura y base 
        //Del rectangulo y que sean puestos de manera correcta
        if (double.TryParse(alturaEntry.Text, out double altura) && altura > 0 &&
            double.TryParse(baseEntry.Text, out double baseRectangulo) && baseRectangulo > 0)
        {
            // Calculamos el perímetro y superficie usando un double el cual usara un 2 y lo multiplicara 
            //Por la altura y la base, Luego hara lo mismo con la superficie haciendo un altura por base 
            double perimetro = 2 * (altura + baseRectangulo);
            double superficie = altura * baseRectangulo;

            // Mostramos los resultados finales en la app declarando el label que se presentara
            perimetroLabel.Text = $"El perímetro del rectángulo es: {perimetro}";
            superficieLabel.Text = $"La superficie del rectángulo es: {superficie}";
        }
        else
        {
            //Y agregamos el label text lo cual nos dira si los valores son validos o son erroneos
            //esto hara el label text no dara un mensaje en la pantalla dando si esta bien o mal
            perimetroLabel.Text = "Por favor, ingrese valores válidos para la altura y la base (mayores que cero).";
            superficieLabel.Text = "";
        }
    }
}