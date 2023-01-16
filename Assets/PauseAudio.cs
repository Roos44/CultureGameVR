using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseAudio : MonoBehaviour
{
    AudioSource[] audioSources;

    void Start()
    {
        audioSources = GetComponents<AudioSource>();
    }

    public void PauseAllAudio()
    {
        foreach (AudioSource audio in audioSources)
        {
            audio.Pause();
        }
    }
}