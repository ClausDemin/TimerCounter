using Assets.Scripts.CounterComponent.Model;
using System;
using System.Collections;
using UnityEngine;

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
