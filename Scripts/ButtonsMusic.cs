using UnityEngine;

public class ButtonsMusic : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    [SerializeField] private ButtonEvent[] _buttons;

    private void OnEnable()
    {
        foreach (var button in _buttons)
        {
            button.Clicked+=PlayButtonClip;
        }
    }

    private void OnDisable()
    {
        foreach (var button in _buttons)
        {
            button.Clicked-=PlayButtonClip;
        }
    }

    public void PlayButtonClip(AudioClip audioClip)
    {
        if(audioClip!=null)
        {
            _audioSource.PlayOneShot(audioClip);
        }
    }
}
