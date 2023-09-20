using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : MonoBehaviour
{
    public GameObject groda;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other != null)
        {
            soundEffects.Instance.FrogSound();
            Destroy(other.gameObject);
        }

    }
}
