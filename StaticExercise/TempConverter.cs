namespace StaticExercise;

public static class TempConverter
{
    public static double CelciusToFahrenheit(double temp)
    {
        return (temp * 9 / 5) + 32;
    }

    public static double FahrenheitToCelcius(double temp)
    {
        return (temp - 32) * 5 / 9;
    }
}