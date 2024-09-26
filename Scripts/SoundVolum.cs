using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundVolum : MonoBehaviour
{
    [SerializeField] AudioMixer _mainMixer;
    [SerializeField] Slider _slider;

    private void Awake()
    {
        _slider.onValueChanged.addListener(modifierVolume);
    }

    public void modifierVolume(float x)
    {
        _mainMixer.setFloat("volumnValue", x);
    }
}
