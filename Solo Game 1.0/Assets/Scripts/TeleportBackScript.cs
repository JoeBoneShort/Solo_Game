using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportBackScript : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player to GS8")
        {
            SceneManager.LoadScene(9);
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
