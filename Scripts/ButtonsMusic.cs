using UnityEngine;

public class ButtonsMusic : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    [SerializeField] private AudioClip[] _buttonClips;
    [SerializeField] private ButtonEvent[] _buttons;

    private void OnEnable()
    {
        foreach (var button in _buttons)
        {
            button.OnClick+=PlayButtonClip;
        }
    }

    private void OnDisable()
    {
        foreach (var button in _buttons)
        {
            button.OnClick-=PlayButtonClip;
        }
    }

    public void PlayButtonClip(int clipIndex)
    {
        if(clipIndex>=0 &&  clipIndex<_buttonClips.Length)
        {
            _audioSource.PlayOneShot(_buttonClips[clipIndex]);
        }
    }
}
