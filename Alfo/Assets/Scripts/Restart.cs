using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public Text score;
    public ScoreManager sm;

    private void Start()
    {
        score.text = sm.score.ToString();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Time.timeScale = 1f;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }
    }
}
