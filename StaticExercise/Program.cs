namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var temp1 = TempConverter.CelciusToFahrenheit(31);
            var temp2 = TempConverter.FahrenheitToCelcius(70);

            Console.WriteLine($"Temp1: {temp1}\nTemp2: {temp2}");
        }
    }
}
