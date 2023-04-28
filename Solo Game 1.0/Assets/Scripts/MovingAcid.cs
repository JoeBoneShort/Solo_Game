using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovingAcid : MonoBehaviour
{
    [SerializeField] Transform[] Positions;
    [SerializeField] float AcidSpeed;

    int NextPosIndex;
    Transform NextPos;

    // Start is called before the first frame update
    void Start()
    {
        NextPos = Positions[0];
    }

    // Update is called once per frame
    void Update()
    {
        MoveGameObject();
    }

    void MoveGameObject()
    {
        if (transform.position == NextPos.position)
        {
            NextPosIndex++;
            if(NextPosIndex >= Positions.Length)
            {
                NextPosIndex = 0;
            }
            NextPos = Positions[NextPosIndex];
        }
        else
        {
            
            transform.position = Vector3.MoveTowards(transform.position, NextPos.position, AcidSpeed * Time.deltaTime) ;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player to GS20")
        {
            SceneManager.LoadScene(35);
        }

        if (collision.tag == "Player to GS19")
        {
            SceneManager.LoadScene(35);
        }

        if (collision.tag == "Player to GS18")
        {
            SceneManager.LoadScene(35);
        }

        if (collision.tag == "Player to GS17")
        {
            SceneManager.LoadScene(35);
        }

        if (collision.tag == "Player to GS16")
        {
            SceneManager.LoadScene(35);
        }

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

       
    }

 
}
