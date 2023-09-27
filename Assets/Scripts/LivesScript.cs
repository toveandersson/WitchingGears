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
    public GameObject visualHealthBar;
    public float eatingTimer = 0;
    public Sprite[] healthChunks = new Sprite[10];

    private void OnCollisionStay2D(Collision2D other)
    {
        eatingTimer -= Time.deltaTime;
        if (other.gameObject.GetComponent<EnemyMovement>() == false)
        {
            return;
        }

        if (eatingTimer < 0) 
        {
            healthBar -= 2;
            eatingTimer += 2;
            SoundEffects.Instance.Eating();
        }
        
        visualHealthBar.GetComponent<SpriteRenderer>().sprite = healthChunks[(healthBar - 1) / 10];

        if (healthBar == 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        SceneManager.LoadSceneAsync(4);
    }

}






