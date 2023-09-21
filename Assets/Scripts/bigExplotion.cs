using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class bigExplotion : MonoBehaviour
{
    public int bewitchedChildren = 0;
    public static bigExplotion Instance { get; private set; }

    public GameObject PowerChordUlt;
    public bool ult = true;
    
    void Start()
    {
        Instance = this;
    }

    public void Points()
    {
        bewitchedChildren++;
        if (bewitchedChildren == 5)
        {
            Ult();
            bewitchedChildren = 0;
        }
    }

    void Update()
    {
        if (Input.GetMouseButton(1) && ult == true)
        {
            ult = false;
            PowerChordUlt.SetActive(true);

            Invoke("falsk", 2f);
        }
    }

    private void falsk()
    {
        PowerChordUlt.SetActive(false);
    }

    public void Ult()
    {
        ult = true;
    }
}
