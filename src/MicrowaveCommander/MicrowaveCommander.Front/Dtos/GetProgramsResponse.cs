namespace MicrowaveCommander.Front.Dtos;

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