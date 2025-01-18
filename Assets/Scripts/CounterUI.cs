using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class CounterUI : MonoBehaviour
{
    [SerializeField] private CounterPresenter _presenter;

    private TextMeshProUGUI _text;

    private const int _LeftMouseButton = 0;

    public void UpdateValue(int value)
    {
        if (_text != null) 
        { 
            _text.text = value.ToString();
        }
    }

    private void Awake()
    {
        _text = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(_LeftMouseButton)) 
        {
            _presenter?.OnMouseButtonClick();
        }
    }
}
