namespace TestBlazorWeb.Services.Counting;

public class CountingService
{
    public int CurrentCount { get; private set; } = 0;

    public void Increment()
    {
        CurrentCount++;
    }
}