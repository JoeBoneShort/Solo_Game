using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SecretTeleporter : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player to GS31")
        {
            SceneManager.LoadScene(36);
        }

        if (collision.tag == "Player to GS24")
        {
            SceneManager.LoadScene(32);
        }

        if (collision.tag == "Player to GS9")
        {
            SceneManager.LoadScene(13);
        }

        if (collision.tag == "Player to GS5")
        {
            SceneManager.LoadScene(14);
        }

        if(collision.tag == "Player to GS4")
        {
            SceneManager.LoadScene(9);
        }
    }
}
