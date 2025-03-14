using UnityEngine;
using UnityEngine.Audio;

public class MasterToggle : MonoBehaviour
{
    private const string MasterMusic = "MasterMusic";

    [SerializeField] private AudioMixer _masterMixer;
    [SerializeField] private float _onVolume = 1f;
    [SerializeField] private float _offVolume = 0.0001f;
    [SerializeField] private float _volumeMultiplier = 20f;

    private bool _isEnable=false;

    public void Toggle()
    {
        if (_isEnable)
        {
            _masterMixer.SetFloat(MasterMusic, Mathf.Log10(_onVolume) * _volumeMultiplier);
        }
        else
        {
            _masterMixer.SetFloat(MasterMusic, Mathf.Log10(_offVolume) * _volumeMultiplier);
        }

        _isEnable=!_isEnable;
    }
}
