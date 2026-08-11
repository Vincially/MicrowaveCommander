using System.Net.Http.Json;
using MicrowaveCommander.Front.Dtos;
using MicrowaveCommander.Front.Services.Interfaces;

namespace MicrowaveCommander.Front.Services;

public class ProgramService : IProgramService
{
    private readonly HttpClient _http;

    public ProgramService(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<GetProgramsResponse>> GetProgramsAsync()
    {
        var result = await _http.GetFromJsonAsync<List<GetProgramsResponse>>("api/programs");
        return result ?? new List<GetProgramsResponse>();
    }
}