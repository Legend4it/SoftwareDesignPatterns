public class LaptopDisplay : IObserver<float>
{

public void OnCompleted()
    {
        Console.WriteLine("Laptop display: Transmission ended.");
    }

    public void OnError(Exception error)
    {
        Console.WriteLine($"Laptop display error: {error.Message}");
    }

    public void OnNext(float temperature)
    {
        Console.WriteLine($"Laptop display updated: Temperature is now {temperature}°C");
    }

}
