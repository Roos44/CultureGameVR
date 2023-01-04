using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslationTool : MonoBehaviour
{

    public AudioClip[] translationClips;
    public AudioSource currentSound;
    public bool isTranslating;

    public int playNext;

    public bool scanVisual;
    public GameObject scanningObjectIcon;
    public GameObject teleportPbjectIcon;
    public int timesTranslated;

    public bool cabTellport;



    // Start is called before the first frame update
    void Start()
    {
        isTranslating = false;
        scanVisual = false;
        scanningObjectIcon.SetActive(false);

    }

    IEnumerator DoScanVisual()
    {
        scanningObjectIcon.SetActive(true);
        yield return new WaitForSeconds(10);
        scanVisual = false;
        scanningObjectIcon.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (scanVisual)
        {
            // Start the Coroutine
            StartCoroutine(DoScanVisual());
        }

        //Button Two = B button on Right Controller
        if (OVRInput.GetDown(OVRInput.Button.Two))
        {

            isTranslating = true;
            cabTellport = true;

        }

        else
        {
            isTranslating = false;
            cabTellport = false;
        }
    }
}
