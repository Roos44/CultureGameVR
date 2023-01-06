using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicTrigger : MonoBehaviour
{
    public AudioClip music; // assign this in the Inspector
    public float targetVolume = 1.0f; // assign this in the Inspector
    public float fadeTime = 2.0f; // assign this in the Inspector
    public float fadeOutTime = 2.0f; // assign this in the Inspector
    public float fadeOutVolume = 0.1f; // assign this in the Inspector
    private AudioSource audioSource;
    private bool startedFadeOut = false;
    private bool volumeCanIncrease;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = music;
        audioSource.Play();
        audioSource.volume = 0.0f;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // play the music and smoothly increase the volume
            volumeCanIncrease = true;
            StartCoroutine(FadeVolume(audioSource, targetVolume, fadeTime));
            
        }
    }

    void Update()
    {
        if (audioSource.isPlaying && !startedFadeOut && volumeCanIncrease)
        {
            // start the fade-out effect after 10 seconds

            startedFadeOut = true;
            StartCoroutine(FadeOutVolume(audioSource, fadeOutVolume, fadeOutTime, 10.0f));
        }
    }

    IEnumerator FadeVolume(AudioSource audioSource, float targetVolume, float fadeTime)
    {
        float startVolume = audioSource.volume;
        float t = 0.0f;

        while (t < 1.0f)
        {
            t += Time.deltaTime / fadeTime;
            audioSource.volume = Mathf.Lerp(startVolume, targetVolume, t);
            yield return null;
        }
    }

    IEnumerator FadeOutVolume(AudioSource audioSource, float targetVolume, float fadeTime, float delay)
    {
        yield return new WaitForSeconds(delay);

        float startVolume = audioSource.volume;
        float t = 0.0f;

        while (t < 1.0f)
        {
            t += Time.deltaTime / fadeTime;
            audioSource.volume = Mathf.Lerp(startVolume, targetVolume, t);
            yield return null;
        }
    }
}
