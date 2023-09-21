using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements.Experimental;

public class pratbubbla : MonoBehaviour
{
    public GameObject tutorialGumma;
    public GameObject tutorialChild;
    public GameObject childPratbubbla;
    public GameObject gummaPratbubbla;
    private bool counter = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !counter)
        {
            StartCoroutine(ShowObjects());
           
        }
        if (Input.GetMouseButtonDown(0) && counter)
        {
            StartCoroutine(ShowObjectsTwo());
        }
    }
    IEnumerator ShowObjects()
    {
        tutorialChild.SetActive(true);
        childPratbubbla.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        counter = true;

    }
    IEnumerator ShowObjectsTwo()
    {       
        tutorialGumma.SetActive(true);
        gummaPratbubbla.SetActive(true);
        yield return new WaitForSeconds(1.5f);

        SceneManager.LoadScene(2);
    }
}







