using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportScript : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player to GS30")
        {
            SceneManager.LoadScene(34);
        }

        if (collision.tag == "Player to GS29")
        {
            SceneManager.LoadScene(33);
        }

        if (collision.tag == "Player to GS28")
        {
            SceneManager.LoadScene(32);
        }

        if (collision.tag == "Player to GS27")
        {
            SceneManager.LoadScene(31);
        }

        if (collision.tag == "Player to GS26")
        {
            SceneManager.LoadScene(30);
        }

        if (collision.tag == "Player to GS25")
        {
            SceneManager.LoadScene(29);
        }

        if (collision.tag == "Player to GS24")
        {
            SceneManager.LoadScene(28);
        }

        if (collision.tag == "Player to GS23")
        {
            SceneManager.LoadScene(27);
        }

        if (collision.tag == "Player to GS22")
        {
            SceneManager.LoadScene(26);
        }

        if (collision.tag == "Player to GS21")
        {
            SceneManager.LoadScene(25);
        }

        if (collision.tag == "Player to GS20")
        {
            SceneManager.LoadScene(24);
        }

        if (collision.tag == "Player to GS19")
        {
            SceneManager.LoadScene(23);
        }

        if (collision.tag == "Player to GS18")
        {
            SceneManager.LoadScene(22);
        }

        if (collision.tag == "Player to GS17")
        {
            SceneManager.LoadScene(21);
        }

        if (collision.tag == "Player to GS16")
        {
            SceneManager.LoadScene(20);
        }

        if (collision.tag == "Player to GS15")
        {
            SceneManager.LoadScene(19);
        }

        if (collision.tag == "Player to GS14")
        {
            SceneManager.LoadScene(18);
        }

        if (collision.tag == "Player to GS13")
        {
            SceneManager.LoadScene(17);
        }

        if (collision.tag == "Player to GS12")
        {
            SceneManager.LoadScene(16);
        }

        if (collision.tag == "Player to GS11")
        {
            SceneManager.LoadScene(15);
        }

        if (collision.tag == "Player to GS10")
        {
            SceneManager.LoadScene(14);
        }

        if (collision.tag == "Player to GS9")
        {
            SceneManager.LoadScene(13);
        }

        if (collision.tag == "Player to GS8")
        {
            SceneManager.LoadScene(12);
        }

        if (collision.tag == "Player to GS7")
        {
            SceneManager.LoadScene(11);
        }

        if (collision.tag == "Player to GS5")
        {
            SceneManager.LoadScene(10);
        }

        if (collision.tag == "Player to GS4")
        {
            SceneManager.LoadScene(8);
        }

        if (collision.tag == "Player to GS3")
        {
            SceneManager.LoadScene(7);
        }

        if (collision.tag == "Player to GS2")
        {
            SceneManager.LoadScene(6);
        }
        
    }

 

}
