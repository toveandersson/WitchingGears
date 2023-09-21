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

    private void Start()
    {
        StartCoroutine(ShowObjects());
    }
    void Update()
    {       

        if (Input.GetMouseButtonDown(0) && !counter)
        {
            tutorialGumma.SetActive(true);
            gummaPratbubbla.SetActive(true);
            counter = true;
        }

        if (Input.GetMouseButtonDown(0) && counter)
        {
            SceneManager.LoadScene(2);
        }
    }
    IEnumerator ShowObjects()
    {
        tutorialChild.SetActive(true);
        childPratbubbla.SetActive(true);
        yield return new WaitForSeconds(0.1f);
    }
}







