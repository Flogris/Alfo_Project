using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartPanel : MonoBehaviour
{
    public GameObject spanel;
    private bool a = false;

    private void Update()
    {
        Time.timeScale = 0f;

        if (Input.GetKeyDown(KeyCode.G))
        {
            spanel.SetActive(false);
            a = true;
        }

        if (a == true)
        {
            Time.timeScale = 1f;
        }
    }
}
