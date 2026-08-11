using MicrowaveCommander.Domain.Entities;
using MicrowaveCommander.Domain.Repositories;
using MicrowaveCommander.Infrastructure.Data;

namespace MicrowaveCommander.Infrastructure.Repositories;

public class ProgramsRepository(AppDbContext context) : IProgramsRepository
{
    public List<Programs> GetPrograms()
    {
        return [.. context.ProgramsDbSet];
    }

    public List<char> GetProcessingStrings()
    {
        throw new NotImplementedException();
    }

    public int AddProgram(Programs program)
    {
        throw new NotImplementedException();
    }
}