using Assets.Scripts.CounterComponent.Interfaces;
using System;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.CounterComponent.Model
{
    public class Counter
    {
        private ICoroutineRunner _coroutineRunner;

        private float _tickTime;
        private int _ticks;

        public Counter(float tickTime, ICoroutineRunner coroutineRunner)
        {
            _ticks = 0;
            _tickTime = tickTime;

            _coroutineRunner = coroutineRunner;
        }

        public event Action<int> Ticked;

        public bool IsRunning { get; private set; }

        public void Run()
        {
            IsRunning = true;

            _coroutineRunner.StartCoroutine(Tick());
        }

        private IEnumerator Tick()
        {
            var awaiting = new WaitForSecondsRealtime(_tickTime);

            while (IsRunning)
            {
                yield return awaiting;
                _ticks++;

                Ticked?.Invoke(_ticks);
            }

            yield break;
        }

        public void Pause()
        {
            IsRunning = false;
        }
    }
}

