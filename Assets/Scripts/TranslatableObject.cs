using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslatableObject : MonoBehaviour
{
    public AudioClip[] clipsToPlay;
    public bool scannable;
    public bool isScaneble;

    public bool isPlaying;

    void Start()
    {
        scannable = true;
        isScaneble = false;
        isPlaying = false;

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && other.gameObject.GetComponent<TranslationTool>().cabTellport)
        {
            isScaneble = true;
            if (scannable)
            {
                other.gameObject.GetComponent<TranslationTool>().timesTranslated++;
                scannable = false;
            }

            AudioSource audioSource = other.gameObject.GetComponent<AudioSource>();

            // Check if the AudioSource is currently playing an audio clip
            if (!audioSource.isPlaying)
            {
                
                if (other.gameObject.GetComponent<TranslationTool>().timesTranslated <= 3)
                {
                    audioSource.PlayOneShot(clipsToPlay[0]);
                }
                else if (other.gameObject.GetComponent<TranslationTool>().timesTranslated > 3 && other.gameObject.GetComponent<TranslationTool>().timesTranslated <= 9 )
                {
                    audioSource.PlayOneShot(clipsToPlay[1]);
                }
                else if (other.gameObject.GetComponent<TranslationTool>().timesTranslated >= 9)
                {
                    audioSource.PlayOneShot(clipsToPlay[2]);
                }
            }


          // if ((OVRInput.GetDown(OVRInput.Button.Two)) && (isPlaying =  true))
          // {
                 //Stop the audio from playing
               // audioSource.Stop();
           // }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<TranslationTool>().scanVisual = true;
    }

    private void OnTriggerExit(Collider other)
    {
        other.gameObject.GetComponent<TranslationTool>().scanVisual = false;
    }

   
}