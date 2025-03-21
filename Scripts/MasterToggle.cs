using UnityEngine;
using UnityEngine.UI;

public class MasterToggle : MonoBehaviour
{
    [SerializeField] private AudioListener _listener;
    [SerializeField] private Button _button;

    private bool _isEnable=false;

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
        _isEnable=!_isEnable;
        _listener.enabled = !_isEnable;
    }
}
