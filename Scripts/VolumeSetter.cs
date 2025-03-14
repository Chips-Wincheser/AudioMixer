using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSetter : MonoBehaviour
{
    private const string BackgroundMusic = "BackgroundMusic";
    private const string ButtonMusic = "ButtonMusic";
    private const string MasterMusic = "MasterMusic";

    [SerializeField] private AudioMixer _masterMixer;
    [SerializeField] private Slider _volumeSlider;
    [SerializeField] private float _volumeMultiplier = 20f;

    private float _musicLvl;

    public void SetVolume(string mixerName)
    {
        _musicLvl = _volumeSlider.value;
        
        if (mixerName==MasterMusic)
        {
            _masterMixer.SetFloat(mixerName, Mathf.Log10(_musicLvl) * _volumeMultiplier);
        }
        else if (mixerName==ButtonMusic)
        {
            _masterMixer.SetFloat(mixerName, Mathf.Log10(_musicLvl) * _volumeMultiplier);
        }
        else if (mixerName==BackgroundMusic)
        {
            _masterMixer.SetFloat(mixerName, Mathf.Log10(_musicLvl) * _volumeMultiplier);
        }
    }
}
