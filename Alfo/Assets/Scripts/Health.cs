using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public GameObject panel;
    public GameObject obje;
    public int health;
    public int maxHealth;

    public Image[] lives;

    public Sprite fullLive;
    public Sprite emptyLive;

    void FixedUpdate()
    {

        if (health > maxHealth)
        {
            health = maxHealth;
        }

        for (int i = 0; i < lives.Length; i++)
        {
            if (i < health)
            {
                lives[i].sprite = fullLive;
            }
            else
            {
                lives[i].sprite = emptyLive;
            }


            if (i < maxHealth)
            {
                lives[i].enabled = true;
            }
            else
            {
                lives[i].enabled = false;
            }
        }
    }

    public void TakeHit(int damage)
    {
        health -= damage;

        if (health <= 0 && obje)
        {
            Destroy(gameObject);
            lives[0].sprite = emptyLive;
            panel.SetActive(true);
            Time.timeScale = 0f;
        }
        else if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void SetHealth(int bonusHealths)
    {
        health += bonusHealths;

        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }
}
