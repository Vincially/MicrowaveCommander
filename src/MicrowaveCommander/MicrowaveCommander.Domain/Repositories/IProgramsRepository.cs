using MicrowaveCommander.Domain.Entities;

namespace MicrowaveCommander.Domain.Repositories;

public interface IProgramsRepository
{
    List<Programs> GetPrograms();
    List<char> GetProcessingStrings();
    public int AddProgram(Programs program);
}