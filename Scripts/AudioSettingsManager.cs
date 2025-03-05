using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioSettingsManager : MonoBehaviour
{
    private const string BackgroundMusic= "BackgroundMusic";
    private const string ButtonMusic = "ButtonMusic";
    private const string MasterMusic = "MasterMusic";

    [SerializeField] private AudioMixer _masterMixer;

    [SerializeField] private Slider _masterVolumeSlider;
    [SerializeField] private Slider _musicVolumeSlider;
    [SerializeField] private Slider _ButtonVolumeSlider;

    private float _masterLvl;
    private float _musicLvl;
    private float _buttonLvl;

    public void SetMasterVolume()
    {
        _masterLvl = _masterVolumeSlider.value;
        _masterMixer.SetFloat(MasterMusic, Mathf.Log10(_masterLvl) * 20);
    }

    public void SetMusicVolume()
    {
        _musicLvl = _musicVolumeSlider.value;
        _masterMixer.SetFloat(BackgroundMusic, Mathf.Log10(_musicLvl) * 20);
    }

    public void SetButtonVolume()
    {
        _buttonLvl = _ButtonVolumeSlider.value;
        _masterMixer.SetFloat(ButtonMusic, Mathf.Log10(_buttonLvl) * 20);
    }
}
