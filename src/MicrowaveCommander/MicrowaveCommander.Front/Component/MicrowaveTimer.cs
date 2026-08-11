namespace MicrowaveCommander.Front.Component;

public class MicrowaveTimer
{
    public MicrowaveTimer(int seconds, int minutes, TimerStatusEnum status)
    {
        RemainingSeconds = seconds;
        RemainingMinutes = minutes;
        Status = status;
    }
    public int RemainingSeconds { get; set; }
    public int RemainingMinutes { get; set; }
    
    public TimerStatusEnum Status { get; set; }
    private Timer Timer { get; set; }

    public void StartTimer(Timer timer)
    {
        Timer = timer;
        Status = TimerStatusEnum.Running;
    }
    
    public void AddHeatingTime(int minutes, int seconds)
    {
        var totalSeconds = RemainingSeconds + seconds;
        do
        {
            if (totalSeconds >= 60)
            {
                RemainingMinutes++;
                totalSeconds -= 60;
            }
        } while (totalSeconds >= 60);

        RemainingMinutes += minutes;
        RemainingSeconds = totalSeconds;
    }

    public void PauseTimer()
    {
        Timer.Dispose();
        Status = TimerStatusEnum.Paused;
    }
    
    public void ResetTimer()
    {
        if (Status != TimerStatusEnum.Stopped)
            Timer.Dispose();
        RemainingMinutes = 0;
        RemainingSeconds = 0;
        Status = TimerStatusEnum.Stopped;
    }
    
}