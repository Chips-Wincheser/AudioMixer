using System;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEvent : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private AudioClip _audioClip;

    public event Action <AudioClip> Clicked;

    protected void OnEnable()
    {
        _button.onClick.AddListener(HandleButtonClick);
    }

    protected void OnDisable()
    {
        _button.onClick.RemoveListener(HandleButtonClick);
    }

    private void HandleButtonClick()
    {
        Clicked?.Invoke(_audioClip);
    }
}
