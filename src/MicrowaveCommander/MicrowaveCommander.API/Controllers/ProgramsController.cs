using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MicrowaveCommander.API.Dtos.Response;
using MicrowaveCommander.Domain.Entities;
using MicrowaveCommander.Domain.Repositories;

namespace MicrowaveCommander.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProgramsController(IProgramsRepository repository) : ControllerBase
{
    [HttpGet]
    public IResult GetPrograms()
    {
        List <Programs> programs = repository.GetPrograms();

        List<GetProgramsResponse> response = programs.Select(p => new GetProgramsResponse
        (
            p.Name,
            p.Meal,
            p.TimeInMinutes,
            p.TimeInSeconds,
            p.Power,
            p.Instructions,
            p.ProcessingString,
            p.IsCustom
        )).ToList();
        
        return Results.Ok(response);
    }
}