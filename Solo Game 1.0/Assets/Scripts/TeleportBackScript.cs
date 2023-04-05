using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportBackScript : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player to GS3")
        {
            SceneManager.LoadScene(1);
        }

        if (collision.tag == "Player to GS2")
        {
            SceneManager.LoadScene(1);
        }

    }
}
