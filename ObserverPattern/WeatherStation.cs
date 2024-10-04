public class WeatherStation : IObservable<float>
{

    private List<IObserver<float>> observers;

    public WeatherStation()
    {
        observers = new List<IObserver<float>>();
    }

    public IDisposable Subscribe(IObserver<float> observer)
    {
        if (!observers.Contains(observer))
        {
            observers.Add(observer);
        }
        return new Unsubscriber(observers, observer);
    }
    public void SetTemperature(float temperature)
    {
        foreach (var observer in observers)
        {
            if (temperature > -100 && temperature < 100) // Simulating valid temperature range
            {
                observer.OnNext(temperature);
            }
            else
            {
                observer.OnError(new Exception("Temperature out of range."));
            }
        }
    }

    public void EndTransmission()
    {
        foreach (var observer in observers)
        {
            observer.OnCompleted();
        }
        observers.Clear();
    }
    
    private class Unsubscriber : IDisposable
    {
        private List<IObserver<float>> _observers;
        private IObserver<float> _observer;

        public Unsubscriber(List<IObserver<float>> observers, IObserver<float> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }

        public void Dispose()
        {
            if (_observer != null && _observers.Contains(_observer))
            {
                _observers.Remove(_observer);
            }
        }
    }
}
