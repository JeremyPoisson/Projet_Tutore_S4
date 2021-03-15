using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class ReglageVolume : MonoBehaviour
{
    [SerializeField] string _parametreVolume = "MasterVolume";
    [SerializeField] AudioMixer _mixer;
    [SerializeField] Slider _slider;

    private void Awake()
    {
        _slider.onValueChanged.AddListener(modifierValeurMixer);
    }

    private void modifierValeurMixer(float x)
    {
        _mixer.SetFloat(_parametreVolume, x);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
