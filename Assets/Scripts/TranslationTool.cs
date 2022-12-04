using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslationTool : MonoBehaviour
{

    public AudioClip[] translationClips;
    public AudioSource currentSound;
    public bool isTranslating;

    public int playNext;


    public int timesTranslated;

    


    // Start is called before the first frame update
    void Start()
    {
        isTranslating = false;
    }

  

    // Update is called once per frame
    void Update()
    {
        //Button Two = B button on Right Controller
        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            
            isTranslating = true;
            /*if(temp != playNext)
            {
                currentSound.PlayOneShot(translationClips[playNext]);
            }
            */
            
        }
        else
        {
            isTranslating = false;
        }
    }
}
