using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnStart : MonoBehaviour
{
    public MeshRenderer onPlayvisable;
    // Start is called before the first frame update
    
    void Start()
    {
        onPlayvisable.enabled = true;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
