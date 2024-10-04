// Create WeatherStation (observable)
WeatherStation weatherStation = new WeatherStation();


// Create observers
PhoneDisplay phone = new PhoneDisplay();
LaptopDisplay laptop = new LaptopDisplay();

// Subscribe observers
IDisposable phoneSubscription = weatherStation.Subscribe(phone);
IDisposable laptopSubscription = weatherStation.Subscribe(laptop);


// Simulate temperature changes
weatherStation.SetTemperature(25.0f);  // Output: Phone and Laptop updated to 25.0°C
weatherStation.SetTemperature(30.0f);  // Output: Phone and Laptop updated to 30.0°C


// End laptop subscription
laptopSubscription.Dispose();

// Change temperature again (only phone is notified)
weatherStation.SetTemperature(35.0f);  // Output: Only Phone updated to 35.0°C

// End transmission
weatherStation.EndTransmission();  // Output: Phone display: Transmission ended.