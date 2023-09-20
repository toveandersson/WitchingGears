using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using Unity.VisualScripting;

public class LivesScript : MonoBehaviour
{
    public int healthBar = 100;
    public TextMeshProUGUI ScoreText;
    public GameObject hBar1;
    public GameObject[] enemies;
    public Sprite[] healthChunks = new Sprite[10];




    private void OnCollisionEnter2D(Collision2D other)
    {
        //Enemy enemies = other.gameObject.GetComponent<Enemy>();
        if (enemies != null)
        {
            Debug.Log("Eating house");
            healthBar -= 5;
            hBar1.GetComponent<SpriteRenderer>().sprite = healthChunks[(healthBar - 1) / 10];
            Debug.Log(healthBar);
            ScoreText.text = "Score: " + healthBar;

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






