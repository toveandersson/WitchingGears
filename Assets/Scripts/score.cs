using System.Collections;
using System.Collections.Generic;
using System.Resources;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Cinemachine.DocumentationSortingAttribute;

public class score : MonoBehaviour
{
    public static score Instance { get; private set; }
    public GameObject frog;
    public GameObject MTwo;

    public int pickedUpFrogs = 0;
    public TextMeshProUGUI scoreText;
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

        if (other.gameObject.GetComponent<Frog>() == false)
        {
            return;
        }

        pickedUpFrogs++;
        scoreText.text = pickedUpFrogs + "/50";
        

        if (pickedUpFrogs % 5 == 0)
        {
            mTwoAppear();
            BigExplotion.Instance.UltTrue();
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

    public void MTwoNotActive()
    {
        MTwo.SetActive(false);
    }

    void youWin()
    {
        SceneManager.LoadSceneAsync(3);
    }

}
