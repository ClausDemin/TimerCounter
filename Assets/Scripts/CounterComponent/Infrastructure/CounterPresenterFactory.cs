using Assets.Scripts.CounterComponent.Model;

namespace Assets.Scripts.CounterComponent.Infrastructure
{
    public class CounterPresenterFactory
    {
        public CounterPresenter Create(Counter counter) 
        {
            return new CounterPresenter(counter);
        }
    }
}
