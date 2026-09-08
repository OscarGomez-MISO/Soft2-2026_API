namespace WebApplication1.Dtos
{
    public class WeatherForecastDto
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }

        public int responseCode { get; set; } = 0;

        public string MessageResponse { get; set; } = string.Empty;
    }
}
