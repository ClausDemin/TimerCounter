using Assets.Scripts.CounterComponent.Interfaces;
using Assets.Scripts.CounterComponent.Model;

namespace Assets.Scripts.CounterComponent.Infrastructure
{
    public class CounterFactory
    {
        public Counter Create(float counterTickTime, ICoroutineRunner coroutineRunner) 
        { 
            return new Counter(counterTickTime, coroutineRunner);
        }
    }
}
