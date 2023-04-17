using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportBackScript : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player to GS12")
        {
            SceneManager.LoadScene(14);
        }

        if (collision.tag == "Player to GS11")
        {
            SceneManager.LoadScene(13);
        }

        if (collision.tag == "Player to GS10")
        {
            SceneManager.LoadScene(12);
        }

        if (collision.tag == "Player to GS9")
        {
            SceneManager.LoadScene(11);
        }

        if (collision.tag == "Player to GS8")
        {
            SceneManager.LoadScene(10);
        }

        if (collision.tag == "Player to GS7")
        {
            SceneManager.LoadScene(8);
        }

        if (collision.tag == "Player to GS6")
        {
            SceneManager.LoadScene(8);
        }

        if (collision.tag == "Player to GS5")
        {
            SceneManager.LoadScene(7);
        }

        if (collision.tag == "Player to GS4")
        {
            SceneManager.LoadScene(6);
        }




        if (collision.tag == "Player to GS3")
        {
            SceneManager.LoadScene(5);
        }

        if (collision.tag == "Player to GS2")
        {
            SceneManager.LoadScene(4);
        }

    }
}
