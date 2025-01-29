using UnityEngine;
using UnityEngine.UI;

public class VolumeScript : MonoBehaviour
{
    public AudioSource audioSource;
    public Slider volumeSlider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        volumeSlider.value = audioSource.volume;
        volumeSlider.onValueChanged.AddListener(OnVolumeChanged);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnVolumeChanged(float volume)
    {
        audioSource.volume = volume;
    }


}
