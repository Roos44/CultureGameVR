using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanging : MonoBehaviour
{

    public bool isScaneble;

    // Start is called before the first frame update
    void Start()
    {
        isScaneble = false;
    }


   private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && other.gameObject.GetComponent<TranslationTool>().cabTellport)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            isScaneble = true;
        }
    }

// Update is called once per frame
void Update()
    {
        
    }
}
