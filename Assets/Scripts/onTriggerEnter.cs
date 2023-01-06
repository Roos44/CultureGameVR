using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onTriggerEnter : MonoBehaviour
{
    public AudioClip clip;
    private AudioSource audioSource;
    
    public GameObject apearingObject;
    public BoxCollider disapearingObject;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        apearingObject.SetActive(false);
        disapearingObject.enabled = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        apearingObject.SetActive(true);
        disapearingObject.enabled = false;
        AudioSource[] audioSources = FindObjectsOfType<AudioSource>();
        foreach (AudioSource source in audioSources)
        {
            if (source.isPlaying)
            {
                source.Stop();
            }
        }

        audioSource.clip = clip;
        audioSource.Play();
    }
}
