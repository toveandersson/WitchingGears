using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class bigExplotion : MonoBehaviour
{
    public static bigExplotion Instance { get; private set; }

    public GameObject PowerChordUlt;
    public GameObject colliderUlt;
    public GameObject groda;
    public GameObject animUlt;

    public int bewitchedChildren = 0;
    public bool ult = false;

    void Start()
    {
        Instance = this;
    }

    void Update()
    {
        if (Input.GetMouseButton(1) && ult == true)
        {
            ult = false;
            DoUlt();
        }
    }

    private void DoUlt()
    {
        PowerChordUlt.SetActive(true);
        Invoke("ColliderActive", 1.2f);
        Invoke("Falsk", 1.8f);
        Invoke("UltCameraShake", 1.1f);
        soundEffects.Instance.Ultimate();
        score.Instance.falsk();
    }

    private void ColliderActive()
    {
        colliderUlt.SetActive(true);
        Invoke("ColliderNotActive", 0.1f);
    }

    private void ColliderNotActive()
    {
        colliderUlt.SetActive(false);
    }
    
    public void Ult()
    {
        ult = true;
    }

    private void UltCameraShake()
    {

        cameraMovement.Instance.ShakeCamera(2.4f, 0.9f);
    }

    private void Falsk()
    {
        PowerChordUlt.SetActive(false);
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
