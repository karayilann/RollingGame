using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class volume : MonoBehaviour
{
    public TextMeshProUGUI duzey;
    public Slider slider;


    public void Start()
    {
        sesyukle();
    }

    public void Update()
    {
        Debug.Log(AudioListener.volume);
    }

    public void sesseviyesi(float value)
    {
        AudioListener.volume = value;
        seshatýrla();
        duzey.text = (slider.value * 100).ToString(); 
    }

    public void seshatýrla()
    {
        PlayerPrefs.SetFloat("sesduzeyi", AudioListener.volume);
    }

    public void sesyukle()
    {
        if (PlayerPrefs.HasKey("sesduzeyi"))
        {
            AudioListener.volume = PlayerPrefs.GetFloat("sesduzeyi");
            slider.value = PlayerPrefs.GetFloat("sesduzeyi");
        }
        else
        {
            PlayerPrefs.SetFloat("sesduzeyi", 0.5f); 
            AudioListener.volume = PlayerPrefs.GetFloat("sesduzeyi");
            slider.value = PlayerPrefs.GetFloat("sesduzeyi");
        }
       
    }

}