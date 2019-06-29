using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : Singleton<SoundManager>
{
    AudioSource morseAudio;

    public void Awake()
    {
        morseAudio = gameObject.AddComponent<AudioSource>();
        morseAudio.loop = true;
        morseAudio.playOnAwake = false;
    }

    private void Start()
    {
        morseAudio.clip = (AudioClip)Resources.Load("Audio/morse");
    }

    public void Init_SoundManager()
    {
        
    }

    public void PlayMorseSound()
    {
        morseAudio.Play();
    }

    public void StopMorseSound()
    {
        morseAudio.Stop();
    }

    public void PlayOneShoot(string soundPath)
    {
        //mainAudio.clip = (AudioClip)Resources.Load(soundPath);
    }
}
