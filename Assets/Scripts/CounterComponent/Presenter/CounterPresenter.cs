using Assets.Scripts.CounterComponent.Model;

public class CounterPresenter
{
    private Counter _counter;

    public CounterPresenter (Counter counter)
    {
        _counter = counter;
    }

    public void OnButtonClick()
    {
        if (_counter.IsRunning)
        {
            _counter.Pause();
        }
        else 
        { 
            _counter.Run();
        }
    }
}
