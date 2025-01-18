using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Counter : MonoBehaviour
{
    [SerializeField] private float _tickTime;

    private int _ticks;
    private bool _isRunning;

    public UnityEvent<int> Ticked;

    public bool IsRunning => _isRunning;

    public void Run() 
    {
        _isRunning = true;

        StartCoroutine(RunTimer());
    }

    public void Pause()
    {
        _isRunning = false;
    }

    private IEnumerator RunTimer()
    {
        while (_isRunning)
        {
            yield return new WaitForSecondsRealtime(_tickTime);

            _ticks++;
            Ticked?.Invoke(_ticks);
        }

        yield break;
    }

    private void Awake()
    {
        _ticks = 0;
    }
}
