using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using Unity.VisualScripting;
using System;

public class LivesScript : MonoBehaviour
{
    public int healthBar = 100;
    public TextMeshProUGUI ScoreText;
    public GameObject hBar1;
    public GameObject[] enemies;
    public Sprite[] healthChunks = new Sprite[10];

    private void OnCollisionEnter2D(Collision2D other)
    {
       // Enemy enemy = other.gameObject.GetComponent<Enemy>();
        if (enemies != null)
        {
          
            healthBar -= 5;
            hBar1.GetComponent<SpriteRenderer>().sprite = healthChunks[(healthBar - 1) / 10];
            Debug.Log("Eating house");
            


        }
        if (healthBar == 0)
        {
            gameOver();
        }
    }

    void gameOver()
    {
        SceneManager.LoadSceneAsync(1);
    }

}






