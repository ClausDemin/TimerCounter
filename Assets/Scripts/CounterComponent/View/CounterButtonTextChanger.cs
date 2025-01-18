using TMPro;
using UnityEngine;

namespace Assets.Scripts.CounterComponent.View
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class CounterButtonTextChanger : MonoBehaviour
    {
        private const string StartTimer = "Запустить счетчик";
        private const string PauseTimer = "Приостановить счетчик";

        [SerializeField] private CounterButtonView _buttonView;
            
        private TextMeshProUGUI _textComponent;
        private string _currentText;

        private void Awake()
        {
            _textComponent = GetComponent<TextMeshProUGUI>();
            _textComponent.text = StartTimer;
            _currentText = StartTimer;
        }

        private void OnEnable()
        {
            _buttonView.Clicked += SwapButtonText;
        }

        private void OnDisable() 
        {
            _buttonView.Clicked -= SwapButtonText;
        }

        private void SwapButtonText() 
        {
            if (_currentText == StartTimer)
            {
                _textComponent.text = PauseTimer;
                _currentText = PauseTimer;
            }
            else 
            {
                _textComponent.text = StartTimer;
                _currentText = StartTimer;
            }
        }
    }
}
