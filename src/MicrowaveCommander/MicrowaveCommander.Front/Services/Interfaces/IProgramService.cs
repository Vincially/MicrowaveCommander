using MicrowaveCommander.Front.Dtos;

namespace MicrowaveCommander.Front.Services.Interfaces;

public interface IProgramService
{
    Task<List<GetProgramsResponse>> GetProgramsAsync();
}