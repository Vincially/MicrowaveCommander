using System.ComponentModel.DataAnnotations;

namespace MicrowaveCommander.Front.Models;

public class HeatingModel
{
    public int? Minutes { get; set; }
    public int? Seconds { get; set; }
    public int? Power { get; set; }
}