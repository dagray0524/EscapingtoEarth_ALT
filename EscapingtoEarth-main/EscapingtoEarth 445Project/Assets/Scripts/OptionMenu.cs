using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.Audio;
public class OptionMenu : MonoBehaviour
{
    //reference to the script:https://www.youtube.com/watch?v=YOaYQrN1oYQ
    // 2nd reference to the script: https://www.youtube.com/watch?v=yWCHaTwVblk

    [SerializeField] Slider volumeSlider;

    void Start()
    {
        if (PlayerPrefs.HasKey("Volume"))
        {
            PlayerPrefs.SetFloat("Volume", 1);
            Load();
        }
        else
        {
            Load();
        }
    }
    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }
    public void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("Volume");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("Volume", volumeSlider.value);
    }
    //public AudioMixer audioMixer;

    //public void SetVolume (float volume)
    //{
    //   audioMixer.SetFloat("Volume", volume);
    //}

}
