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
    public GameObject groda;
    public GameObject animUlt;

    
    void Start()
    {
        Instance = this;
    }


    void Update()
    {
        if (Input.GetMouseButton(1) && ult == true)
        {
            ult = false;
            PowerChordUlt.SetActive(true);
            Invoke("colliderActive", 1.2f);
            Invoke("falsk", 1.8f);
            Invoke("ultCameraShake", 1.1f);
            soundEffects.Instance.Ultimate();
            score.Instance.falsk();

        }
    }

    private void ultCameraShake()
    {

        cameraMovement.Instance.ShakeCamera(2.4f, 0.9f);
    }

    private void colliderActive()
    {
        colliderUlt.SetActive(true);
        Invoke("colliderNotActive", 0.1f);
    }

    private void colliderNotActive()
    {
        colliderUlt.SetActive(false);
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
            Quaternion noRotation = Quaternion.identity;
            GameObject newGroda = Instantiate(groda, other.transform.position, noRotation);
            GameObject newExplosion = Instantiate(animUlt, other.transform.position, noRotation);

            Destroy(newExplosion, 0.5f);

        }
    }
}
