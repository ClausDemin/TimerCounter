using Assets.Scripts.CounterComponent.Infrastructure;
using Assets.Scripts.CounterComponent.Model;
using UnityEngine;

namespace Assets.Scripts.CounterComponent
{
    public class EntryPoint: MonoBehaviour
    {
        [SerializeField] private CounterView _counterView;
        [SerializeField] private CounterButtonView _counterButton;
        [SerializeField] private CoroutineRunner _coroutineRunner;

        [SerializeField] private float _counterTickTime;

        private void Awake()
        {
            CounterFactory counterFactory = new CounterFactory();
            CounterPresenterFactory counterPresenterFactory = new CounterPresenterFactory();

            Counter counter = counterFactory.Create(_counterTickTime, _coroutineRunner);
            CounterPresenter presenter = counterPresenterFactory.Create(counter);

            _counterView.Initialize(presenter);
            _counterButton.Initialize(presenter);

            counter.Ticked += _counterView.UpdateValue;
        }
    }
}
