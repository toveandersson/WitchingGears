using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigExplotion : MonoBehaviour
{
    public GameObject PowerChordUlt;
    
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            GameObject powerChordUlt = Instantiate(PowerChordUlt, transform.position, transform.rotation);

            Destroy(powerChordUlt, 1);
        }
    }
}
