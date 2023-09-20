using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : MonoBehaviour
{
    public GameObject frog;
    private void OnTriggerEnter2D(Collider2D collision)
    {
            soundEffects.Instance.FrogSound();
            Destroy(gameObject);

    }
}
