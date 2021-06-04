using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackGroundMusic : MonoBehaviour
{

    public Slider slider;
    public AudioClip music;
    private AudioSource back;
    void Start()
    {
        back = this.GetComponent<AudioSource>();
        back.loop = true;
        back.volume = 0.5f; //0-1
        back.clip = music;
        back.Play();
    }

    void Update()
    {
        back.volume = slider.value;
    }
}
