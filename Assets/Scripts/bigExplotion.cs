using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class bigExplotion : MonoBehaviour
{
    public int bewitchedChildren = 0;
    public static bigExplotion Instance { get; private set; }

    public GameObject PowerChordUlt;
    public GameObject colliderUlt;
    public bool ult = false;
    
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
            Invoke("colliderActive", 1.2f);
            Invoke("falsk", 1.8f);
        }
    }

    private void colliderActive()
    {
        colliderUlt.SetActive(true);
    }

    private void falsk()
    {
        PowerChordUlt.SetActive(false);
    }

    public void Ult()
    {
        ult = true;
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            // Call the DestroyEnemy() method on the enemy script
            Destroy(other.gameObject);
        }
    }
}
