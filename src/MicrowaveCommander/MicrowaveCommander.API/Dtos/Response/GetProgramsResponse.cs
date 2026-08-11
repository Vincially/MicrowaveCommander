namespace MicrowaveCommander.API.Dtos.Response;

public record GetProgramsResponse(
    string Name,
    string Meal,
    int TimeInMinutes,
    int TimeInSeconds,
    int Power,
    string Instructions,
    string ProcessingString,
    bool IsCustom
    );