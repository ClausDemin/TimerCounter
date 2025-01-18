using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class CounterView : MonoBehaviour
{
    private CounterPresenter _presenter;

    private TextMeshProUGUI _text;

    private void Awake()
    {
        _text = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateValue(int value)
    {
        if (_text == null) 
        { 
            return;
        }

        _text.text = value.ToString();
    }

    public void Initialize(CounterPresenter presenter)
    {
        _presenter = presenter;
    }
}
