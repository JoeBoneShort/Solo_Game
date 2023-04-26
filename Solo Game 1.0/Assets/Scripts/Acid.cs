using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Acid : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player to GS15")
        {
            SceneManager.LoadScene(35);
        }

        if (collision.tag == "Player to GS14")
        {
            SceneManager.LoadScene(35);
        }

        if (collision.tag == "Player to GS13")
        {
            SceneManager.LoadScene(35);
        }

        if (collision.tag == "Player to GS12")
        {
            SceneManager.LoadScene(35);
        }
        if(collision.tag == "Player to GS11")
        {
            SceneManager.LoadScene(35);
        }
    }
}
