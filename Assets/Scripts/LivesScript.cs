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
    public float eatingTimer = 0;

    public Sprite[] healthChunks = new Sprite[10];

    private void Update()
    {
        
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        eatingTimer -= Time.deltaTime;
        if (other.gameObject.GetComponent<EnemyMovement>() == false)
        {
            return;
        }

        if (eatingTimer < 0) 
        {
            healthBar -= 1;
            eatingTimer += 2;
        }
        
        hBar1.GetComponent<SpriteRenderer>().sprite = healthChunks[(healthBar - 1) / 10];

        if (healthBar == 0)
        {
            gameOver();
        }
    }

    void gameOver()
    {
        SceneManager.LoadSceneAsync(4);
    }

}






