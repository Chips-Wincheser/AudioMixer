using UnityEngine;
using UnityEngine.Audio;

public class MasterToggle : MonoBehaviour
{
    private const string MasterMusic = "MasterMusic";

    [SerializeField] private AudioMixer _masterMixer;

    private bool _isEnable=false;

    public void Toggle()
    {
        if (_isEnable)
        {
            _masterMixer.SetFloat(MasterMusic, Mathf.Log10(1) * 20);
        }
        else
        {
            _masterMixer.SetFloat(MasterMusic, Mathf.Log10(0.0001f) * 20);
        }

        _isEnable=!_isEnable;
    }
}
