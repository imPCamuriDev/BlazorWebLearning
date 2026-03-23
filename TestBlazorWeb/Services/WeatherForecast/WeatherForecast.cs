namespace TestBlazorWeb.Services.WeatherForecast;

public class WeatherForecast
{
    public DateOnly Date { get; set; }
    public int? TemperatureC { get; set; }
    public string? Summary { get; set; } 
    public int? TemperatureF => 32 + (int?)(TemperatureC / 0.5556);
    
    public static WeatherForecast[] OnInitialize(string[] summaries, DateOnly date)
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = date.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = summaries[Random.Shared.Next(summaries.Length)]
        }).ToArray();
    }
    
}