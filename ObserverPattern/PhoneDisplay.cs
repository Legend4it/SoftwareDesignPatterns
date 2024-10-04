public class PhoneDisplay : IObserver<float>
{
    public void OnCompleted()
    {
        Console.WriteLine("Phone display: Transmission ended.");
    }

    public void OnError(Exception error)
    {
        Console.WriteLine($"Phone display error: {error.Message}");
    }

    public void OnNext(float temperature)
    {
        Console.WriteLine($"Phone display updated: Temperature is now {temperature}°C");
    }
}
