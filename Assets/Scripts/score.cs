using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Cinemachine.DocumentationSortingAttribute;

public class score : MonoBehaviour
{
    public int pickedUpFrogs = 0;
    public TextMeshProUGUI scoreText;
    public GameObject frog;


    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = pickedUpFrogs + "/50";
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other != null)
        {
            pickedUpFrogs++;
            scoreText.text = pickedUpFrogs + "/50";
        }

        if (pickedUpFrogs == 50)
        {
            youWin();
        }
            
    }

    

    void youWin()
    {
        SceneManager.LoadSceneAsync(3);
    }

}
