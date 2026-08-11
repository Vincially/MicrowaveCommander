namespace MicrowaveCommander.Domain.Entities;

public class Programs
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Meal { get; set; }
    public int TimeInMinutes { get; set; }
    public int TimeInSeconds { get; set; }
    public int Power { get; set; }
    public string Instructions { get; set; }
    public string ProcessingString { get; set; }
    public bool IsCustom { get; set; }
}