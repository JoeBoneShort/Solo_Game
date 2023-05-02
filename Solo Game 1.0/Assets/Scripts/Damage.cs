using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{

    public float damage = 10f; //the damage amount to inflict on collision
    public string targetTag = "Acid"; //the tag of the target object to damage

    void OnCollisionEnter(Collision collision)
    { //a method that is called when a collision happens
        if (collision.gameObject.tag == targetTag)
        { //check if the collided object has the target tag
           Boss targetHealth = collision.gameObject.GetComponent<Boss>(); //get the Health component of the target object
            if (targetHealth != null)
            { //check if the target object has a Health component
                targetHealth.TakeDamage(damage); //call the TakeDamage function on the target object's Health component
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

}
