using UnityEngine;

public class CounterPresenter: MonoBehaviour
{
    [SerializeField] private Counter _counter;

    public void OnMouseButtonClick()
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
