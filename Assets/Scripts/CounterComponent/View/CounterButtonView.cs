using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class CounterButtonView : MonoBehaviour
{
    private CounterPresenter _presenter;
    private Button _button;

    public event Action Clicked;

    public void Initialize(CounterPresenter presenter)
    {
        _button = GetComponent<Button>();
        _presenter = presenter;

        _button?.onClick.AddListener(OnClick);
    }

    private void OnClick() 
    {
        _presenter.OnButtonClick();
        Clicked?.Invoke();
    }
}
