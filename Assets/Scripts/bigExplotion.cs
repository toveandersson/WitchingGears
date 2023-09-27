using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BigExplotion : MonoBehaviour
{
    public static BigExplotion Instance { get; private set; }

    public GameObject PowerChordUlt; //ult
    public GameObject colliderUlt; //ultens collider
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
        Invoke(nameof(ColliderActive), 1.2f);
        Invoke(nameof(PowerChordUltOver), 1.8f);
        Invoke(nameof(UltCameraShake), 1.1f);
        SoundEffects.Instance.Ultimate();
        score.Instance.falsk();
    }

    private void ColliderActive()
    {
        colliderUlt.SetActive(true);
        Invoke(nameof(ColliderNotActive), 0.1f);
    }

    private void PowerChordUltOver()
    {
        PowerChordUlt.SetActive(false);
    }
    private void UltCameraShake()
    {
        CameraMovement.Instance.ShakeCamera(2.4f, 0.9f);
    }

    private void ColliderNotActive()
    {
        colliderUlt.SetActive(false);
    }
    
    public void UltTrue()
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
