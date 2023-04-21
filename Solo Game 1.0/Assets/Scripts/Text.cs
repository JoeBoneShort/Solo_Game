using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    [SerializeField]
    private Text yourText;


    // Start is called before the first frame update
    void Start()
    {
        yourText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
          
            yourText.enabled = true; 
        }
    }


    void OnCollisionExit2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            yourText.enabled = false; 
        }
    }
}
