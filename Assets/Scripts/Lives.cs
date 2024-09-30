using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lives : MonoBehaviour
{
    public int life;
    public int numberOfLives;

    public Image[] lives;
    public Sprite emptyBall;
    public Sprite fullBall;

    public void LoseLife(int amount)
    {
        life -= amount;
        if(life <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    void Update()
    {
        if (life > numberOfLives)
        {
            life = numberOfLives;
        }


        for (int i = 0; i < lives.Length; i++)
        {
            if (i < life)
            {
                lives[i].sprite = fullBall;
            }
            else
            {
                lives[i].sprite = emptyBall;
            }

            if (i < numberOfLives)
            {
                lives[i].enabled = true;
            }
            else
            {
                lives[i].enabled = false;
            }
        }
    }
}
