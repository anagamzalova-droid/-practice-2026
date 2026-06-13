csharp
public static class TemperatureConverter
{
    public static double CelsiusToFahrenheit(double celsius) => celsius * 9 / 5 + 32;
    public static double CelsiusToKelvin(double celsius) => celsius + 273.15;
    public static double FahrenheitToCelsius(double fahrenheit) => (fahrenheit - 32) * 5 / 9;
}
csharp
private void txtCelsius_TextChanged(object sender, EventArgs e)
{
    if (double.TryParse(txtCelsius.Text, out double c))
    {
        txtFahrenheit.Text = TemperatureConverter.CelsiusToFahrenheit(c).ToString("F2");
        txtKelvin.Text = TemperatureConverter.CelsiusToKelvin(c).ToString("F2");
    }
}
