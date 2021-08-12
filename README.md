# Introduction
This API is to show some explains of things we are seeing within [NerdVision](https://nerd.vision)

## How to Run
### Testing .NET 5
 - Start the application by running `dotnet run -c Release --framework net5.0`
 - Set a tracepoint in [NerdVision](https://nerd.vision) in the file `Controllers/WeatherForecastController.cs:29`
 - Set a tracepoint in [NerdVision](https://nerd.vision) in the file `Controllers/WeatherForecastController.cs:30` that logs a message that prints "Test log message"
 - Open a browser and hit `http://localhost:5000/weatherforecast`

#### Behavior
No snapshots will occur, but the application will show as connected.  No logs are shown either.

### Testing .NET 3.1
 - Start the application by running `dotnet run -c Release --framework netcoreapp3.1`
 - Set a tracepoint in [NerdVision](https://nerd.vision) in the file `Controllers/WeatherForecastController.cs:29`
 - Set a tracepoint in [NerdVision](https://nerd.vision) in the file `Controllers/WeatherForecastController.cs:30` that logs a message that prints "Test log message"
 - Open a browser and hit `http://localhost:5000/weatherforecast`

#### Behavior
Snapshot will occur, but variables will not display.  The application shows as connected and you can see the Frames.  You will see "no_frame" snapshots for the tracepoint that logs, but no logs.