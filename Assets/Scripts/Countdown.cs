using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Countdown : MonoBehaviour
{

    public float timevalude;
    public GameObject apearing_Objects;


    // Start is called before the first frame update
    void Start()
    {
        apearing_Objects.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        countdown();
    }


    public void countdown()
    {

        if (timevalude > 0)
        {
            timevalude -= Time.deltaTime;
        }
        else
        {
            timevalude = 0;
            apearing_Objects.SetActive(true);

        }

    }


}
