using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Cinemachine.DocumentationSortingAttribute;

public class score : MonoBehaviour
{

    public static score Instance { get; private set; }
    public int pickedUpFrogs = 0;
    public TextMeshProUGUI scoreText;
    public GameObject frog;
    public GameObject MTwo;
    void Start()
    {
        scoreText.text = pickedUpFrogs + "/50";
    }

    private void Awake()
    {
        Instance = this;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other != null)
        {
            pickedUpFrogs++;
            scoreText.text = pickedUpFrogs + "/50";
        }

        if (pickedUpFrogs == 5 || pickedUpFrogs == 10 || pickedUpFrogs == 15 || pickedUpFrogs == 20 || pickedUpFrogs == 25 || pickedUpFrogs == 30 || pickedUpFrogs == 35 || pickedUpFrogs == 40 || pickedUpFrogs == 45)
        {
            mTwoAppear();
        }
        if (pickedUpFrogs == 50)
        {
            youWin();
        }
            
    }

    public void mTwoAppear()
    {
        MTwo.SetActive(true);
    }

    public void falsk()
    {
        MTwo.SetActive(false);

    }

    void youWin()
    {
        SceneManager.LoadSceneAsync(3);
    }

}
