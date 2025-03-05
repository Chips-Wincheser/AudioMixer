using UnityEngine;

public class ButtonsMusic : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    [SerializeField] private AudioClip[] _buttonClips;

    public void PlayButtonClip(int clipIndex)
    {
        if(clipIndex>=0 &&  clipIndex<_buttonClips.Length)
        {
            _audioSource.PlayOneShot(_buttonClips[clipIndex]);
        }
    }
}
