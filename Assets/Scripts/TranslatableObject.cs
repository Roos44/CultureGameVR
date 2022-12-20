using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslatableObject : MonoBehaviour
{

    //public int audioClipNumber;
    public AudioClip[] clipsToPlay;
    public bool scannable;
    //public bool isScaneble;

    // Start is called before the first frame update
    void Start()
    {
        scannable = true;
        //isScaneble = false;


    }
   private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && other.gameObject.GetComponent<TranslationTool>().isTranslating)
        {
            //isScaneble = true;
            if (scannable)
            {
                other.gameObject.GetComponent<TranslationTool>().timesTranslated++;
                scannable = false;
            }
            

            if(other.gameObject.GetComponent<TranslationTool>().timesTranslated == 1)
            {
                other.gameObject.GetComponent<AudioSource>().PlayOneShot(clipsToPlay[0]);
            }
            else if (other.gameObject.GetComponent<TranslationTool>().timesTranslated == 2)
            {
                other.gameObject.GetComponent<AudioSource>().PlayOneShot(clipsToPlay[1]);
            }
            else if (other.gameObject.GetComponent<TranslationTool>().timesTranslated >= 3)
            {
                other.gameObject.GetComponent<AudioSource>().PlayOneShot(clipsToPlay[2]);

            }
        }
    }


  //  private void OnTriggerExit(Collider other)
   // {
   //     isScaneble = false;
   // }

    // Update is called once per frame
    void Update()
    {
        
    }
}




/* Old Code Below
 * 
 * if (other.gameObject.tag == "Player" && other.gameObject.GetComponent<TranslationTool>().isTranslating && other.gameObject.GetComponent<TranslationTool>().timesTranslated == 0)
        {
            other.gameObject.GetComponent<AudioSource>().PlayOneShot(clipsToPlay[0]);
            if (scannable)
            {
                other.gameObject.GetComponent<TranslationTool>().timesTranslated++;
                scannable = false;
            }

        }
        else if(other.gameObject.tag == "Player" && other.gameObject.GetComponent<TranslationTool>().isTranslating && other.gameObject.GetComponent<TranslationTool>().timesTranslated == 1)
        {
            other.gameObject.GetComponent<AudioSource>().PlayOneShot(clipsToPlay[1]);
            if (scannable)
            {
                other.gameObject.GetComponent<TranslationTool>().timesTranslated++;
                scannable = false;
            }
        }
        else if(other.gameObject.tag == "Player" && other.gameObject.GetComponent<TranslationTool>().isTranslating && other.gameObject.GetComponent<TranslationTool>().timesTranslated >= 2)
        {
            other.gameObject.GetComponent<AudioSource>().PlayOneShot(clipsToPlay[2]);
            if (scannable)
            {
                other.gameObject.GetComponent<TranslationTool>().timesTranslated++;
                scannable = false;
            }
        }

*/
