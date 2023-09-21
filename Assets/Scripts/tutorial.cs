using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tutorial : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Invoke("Tutorial", 0.1f);
        }
    }

    void Tutorial()
    {
        SceneManager.LoadScene(2);

    }

}
