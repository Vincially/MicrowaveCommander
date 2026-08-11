namespace MicrowaveCommander.API.Dtos.Requests;

public record CreateCustomProgramRequest(
    string Name,
    string Meal,
    int TimeInMinutes,
    int TimeInSeconds,
    int Power,
    string Instructions,
    char ProcessingString);
